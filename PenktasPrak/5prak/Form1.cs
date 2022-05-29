using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penktasPraktinis
{
    public partial class Form1 : Form
    {
        private int port1 = 7000;
        private int port2 = 7001;

        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button1.BackColor = Color.LightSteelBlue;
            panel1.Visible = true;
            var primaryNumbers = new string[] { "2", "3", "5", "7", "11", "13", "17", "19", "23", "29", "31", "37", "41", "43", "47", "53", "59", "61", "67", "71", "73", "79", "83", "89", "97", "101" };
            comboBox1Q.Items.AddRange(primaryNumbers);
            comboBox1P.Items.AddRange(primaryNumbers);
        }

        private void button1Send_Click(object sender, EventArgs e)
        {
            int p, q;
            if (int.TryParse(comboBox1P.Text, out p) && int.TryParse(comboBox1Q.Text, out q))
            {
                string plainNumbers = "";
                string cipherNumbers = "";
                string text = richTextBox1Plaintext.Text;
                var encrypted = RSACipher.Sign(text, p, q);
                var plainBytes = Encoding.ASCII.GetBytes(text);
                char[] cipherText = new char[encrypted.Length];
                int[] encryptedNumbers = new int[encrypted.Length];
                for (int i = 0; i < encrypted.Length; i++)
                {
                    plainNumbers += int.Parse(plainBytes[i].ToString()) + " ";
                    cipherNumbers += encrypted[i] + " ";
                    cipherText[i] = (char)encrypted[i];
                    encryptedNumbers[i] = encrypted[i];
                }
                richTextBox1Ciphertext.Text = "Zinutes skaitmenine reiksme:\n" + plainNumbers + "\n";
                richTextBox1Ciphertext.AppendText("Paraso skaitmenine reiksme:\n" + cipherNumbers + "\n");
                BigInteger keyPri = RSACipher.GetPrivateKey();
                BigInteger[] keyPub = RSACipher.GetPublicKey();
                label1KeyPrivate.Text = "PrivatusRaktas = ( " + keyPri + " )";
                label1KeyPublic.Text = "ViesasRaktas = ( " + keyPub[0] + "; " + keyPub[1] + " )";
                Client.Send(port1, keyPub, plainNumbers, cipherNumbers);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button2.BackColor = Color.LightSteelBlue;
            panel2.Visible = true;
            Task.Run(() => this.ListenServer());
        }

        private void ListenServer()
        {
            BigInteger[] keyPub = new BigInteger[2];
            string message = "", signature = "";
            Server.Start(port1, ref keyPub, ref message, ref signature);
            richTextBox2Message.Invoke(new MethodInvoker(delegate ()
            {
                richTextBox2Message.Text = message;
            }));
            richTextBox2Signature.Invoke(new MethodInvoker(delegate ()
            {
                richTextBox2Signature.Text = signature;
            }));
            label2KeyPublic.Invoke(new MethodInvoker(delegate ()
            {
                label2KeyPublic.Text = "ViesasRaktas = ( " + keyPub[0] + "; " + keyPub[1] + " )";
            }));
            ListenServer();
        }

        private void button2Send_Click(object sender, EventArgs e)
        {
            string str = label2KeyPublic.Text;
            str = str.Replace("ViesasRaktas = ( ", "");
            str = str.Replace("; ", " ");
            str = str.Replace(" )", "");
            string[] strArray = str.Split(' ');
            BigInteger[] keyPub = new BigInteger[2];
            keyPub[0] = BigInteger.Parse(strArray[0]);
            keyPub[1] = BigInteger.Parse(strArray[1]);
            Client.Send(port2, keyPub, richTextBox2Message.Text, richTextBox2Signature.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button3.BackColor = Color.LightSteelBlue;
            panel3.Visible = true;
            Task.Run(() => this.ListenClient());
        }

        private void ListenClient()
        {
            BigInteger[] keyPub = new BigInteger[2];
            string message = "", signature = "";
            Server.Start(port2, ref keyPub, ref message, ref signature);
            richTextBox3Message.Invoke(new MethodInvoker(delegate ()
            {
                richTextBox3Message.Text = message;
            }));
            richTextBox3Signature.Invoke(new MethodInvoker(delegate ()
            {
                richTextBox3Signature.Text = signature;
            }));
            label3KeyPublic.Invoke(new MethodInvoker(delegate ()
            {
                label3KeyPublic.Text = "ViesasRaktas = ( " + keyPub[0] + "; " + keyPub[1] + " )";
            }));
            string[] signatureStringArray = signature.Split(' ');
            int length = signatureStringArray.Length;
            if (signatureStringArray[signatureStringArray.Length - 1] == "")
                length = signatureStringArray.Length - 1;
            int[] signatureIntArray = new int[length];
            for (int i = 0; i < signatureIntArray.Length; i++)
            {
                signatureIntArray[i] = int.Parse(signatureStringArray[i]);
                //MessageBox.Show(signatureIntArray[i] + "");
            }
            int[] messageIntArray = RSACipher.Unsign(signatureIntArray, keyPub);
            string messageStr = "";
            foreach(var ch in messageIntArray)
            {
                messageStr += ch + " ";
            }
            richTextBox3MessageFromSignature.Invoke(new MethodInvoker(delegate ()
            {
                richTextBox3MessageFromSignature.Text = messageStr;
            }));
            label3SignatureConfirm.Invoke(new MethodInvoker(delegate ()
            {
                if (message == messageStr)
                    label3SignatureConfirm.Text = "Parasas patvirtintas";
                else
                    label3SignatureConfirm.Text = "Parasas nebuvo patvirtintas";
            }));
            ListenClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
