
namespace penktasPraktinis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1Plaintext = new System.Windows.Forms.RichTextBox();
            this.button1Send = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1KeyPrivate = new System.Windows.Forms.Label();
            this.richTextBox1Ciphertext = new System.Windows.Forms.RichTextBox();
            this.label1KeyPublic = new System.Windows.Forms.Label();
            this.comboBox1P = new System.Windows.Forms.ComboBox();
            this.comboBox1Q = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2KeyPublic = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2Send = new System.Windows.Forms.Button();
            this.richTextBox2Signature = new System.Windows.Forms.RichTextBox();
            this.richTextBox2Message = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3SignatureConfirm = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox3MessageFromSignature = new System.Windows.Forms.RichTextBox();
            this.label3KeyPublic = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox3Message = new System.Windows.Forms.RichTextBox();
            this.richTextBox3Signature = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1Plaintext
            // 
            this.richTextBox1Plaintext.Location = new System.Drawing.Point(4, 50);
            this.richTextBox1Plaintext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1Plaintext.Name = "richTextBox1Plaintext";
            this.richTextBox1Plaintext.Size = new System.Drawing.Size(181, 82);
            this.richTextBox1Plaintext.TabIndex = 0;
            this.richTextBox1Plaintext.Text = "";
            // 
            // button1Send
            // 
            this.button1Send.Location = new System.Drawing.Point(4, 136);
            this.button1Send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1Send.Name = "button1Send";
            this.button1Send.Size = new System.Drawing.Size(180, 24);
            this.button1Send.TabIndex = 1;
            this.button1Send.Text = "Siusti";
            this.button1Send.UseVisualStyleBackColor = true;
            this.button1Send.Click += new System.EventHandler(this.button1Send_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Paspauskite norint pereiti prie pirmos aplikacijos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Paspauskite norint pereiti prie antros aplikacijos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Paspauskite norint pereiti prie trecios aplikacijos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1KeyPrivate);
            this.panel1.Controls.Add(this.richTextBox1Ciphertext);
            this.panel1.Controls.Add(this.label1KeyPublic);
            this.panel1.Controls.Add(this.comboBox1P);
            this.panel1.Controls.Add(this.comboBox1Q);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBox1Plaintext);
            this.panel1.Controls.Add(this.button1Send);
            this.panel1.Location = new System.Drawing.Point(15, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 316);
            this.panel1.TabIndex = 5;
            // 
            // label1KeyPrivate
            // 
            this.label1KeyPrivate.AutoSize = true;
            this.label1KeyPrivate.Location = new System.Drawing.Point(9, 295);
            this.label1KeyPrivate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1KeyPrivate.Name = "label1KeyPrivate";
            this.label1KeyPrivate.Size = new System.Drawing.Size(77, 13);
            this.label1KeyPrivate.TabIndex = 19;
            this.label1KeyPrivate.Text = "Privatus raktas";
            // 
            // richTextBox1Ciphertext
            // 
            this.richTextBox1Ciphertext.Location = new System.Drawing.Point(4, 181);
            this.richTextBox1Ciphertext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1Ciphertext.Name = "richTextBox1Ciphertext";
            this.richTextBox1Ciphertext.ReadOnly = true;
            this.richTextBox1Ciphertext.Size = new System.Drawing.Size(181, 98);
            this.richTextBox1Ciphertext.TabIndex = 18;
            this.richTextBox1Ciphertext.Text = "";
            // 
            // label1KeyPublic
            // 
            this.label1KeyPublic.AutoSize = true;
            this.label1KeyPublic.Location = new System.Drawing.Point(9, 281);
            this.label1KeyPublic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1KeyPublic.Name = "label1KeyPublic";
            this.label1KeyPublic.Size = new System.Drawing.Size(75, 13);
            this.label1KeyPublic.TabIndex = 20;
            this.label1KeyPublic.Text = "Viesas Raktas";
            // 
            // comboBox1P
            // 
            this.comboBox1P.FormattingEnabled = true;
            this.comboBox1P.Location = new System.Drawing.Point(60, 2);
            this.comboBox1P.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1P.Name = "comboBox1P";
            this.comboBox1P.Size = new System.Drawing.Size(164, 21);
            this.comboBox1P.TabIndex = 17;
            // 
            // comboBox1Q
            // 
            this.comboBox1Q.FormattingEnabled = true;
            this.comboBox1Q.Location = new System.Drawing.Point(60, 27);
            this.comboBox1Q.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1Q.Name = "comboBox1Q";
            this.comboBox1Q.Size = new System.Drawing.Size(164, 21);
            this.comboBox1Q.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pirminis q:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pirminis p:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2KeyPublic);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button2Send);
            this.panel2.Controls.Add(this.richTextBox2Signature);
            this.panel2.Controls.Add(this.richTextBox2Message);
            this.panel2.Location = new System.Drawing.Point(331, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 317);
            this.panel2.TabIndex = 6;
            // 
            // label2KeyPublic
            // 
            this.label2KeyPublic.AutoSize = true;
            this.label2KeyPublic.Location = new System.Drawing.Point(4, 214);
            this.label2KeyPublic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2KeyPublic.Name = "label2KeyPublic";
            this.label2KeyPublic.Size = new System.Drawing.Size(70, 13);
            this.label2KeyPublic.TabIndex = 25;
            this.label2KeyPublic.Text = "Viesas raktas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Parasas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Zinute";
            // 
            // button2Send
            // 
            this.button2Send.Location = new System.Drawing.Point(4, 255);
            this.button2Send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2Send.Name = "button2Send";
            this.button2Send.Size = new System.Drawing.Size(180, 24);
            this.button2Send.TabIndex = 21;
            this.button2Send.Text = "Siusti";
            this.button2Send.UseVisualStyleBackColor = true;
            this.button2Send.Click += new System.EventHandler(this.button2Send_Click);
            // 
            // richTextBox2Signature
            // 
            this.richTextBox2Signature.Location = new System.Drawing.Point(4, 130);
            this.richTextBox2Signature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox2Signature.Name = "richTextBox2Signature";
            this.richTextBox2Signature.Size = new System.Drawing.Size(181, 82);
            this.richTextBox2Signature.TabIndex = 22;
            this.richTextBox2Signature.Text = "";
            // 
            // richTextBox2Message
            // 
            this.richTextBox2Message.Location = new System.Drawing.Point(4, 22);
            this.richTextBox2Message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox2Message.Name = "richTextBox2Message";
            this.richTextBox2Message.ReadOnly = true;
            this.richTextBox2Message.Size = new System.Drawing.Size(181, 82);
            this.richTextBox2Message.TabIndex = 21;
            this.richTextBox2Message.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3SignatureConfirm);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.richTextBox3MessageFromSignature);
            this.panel3.Controls.Add(this.label3KeyPublic);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.richTextBox3Message);
            this.panel3.Controls.Add(this.richTextBox3Signature);
            this.panel3.Location = new System.Drawing.Point(645, 89);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 317);
            this.panel3.TabIndex = 7;
            // 
            // label3SignatureConfirm
            // 
            this.label3SignatureConfirm.AutoSize = true;
            this.label3SignatureConfirm.Location = new System.Drawing.Point(2, 296);
            this.label3SignatureConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3SignatureConfirm.Name = "label3SignatureConfirm";
            this.label3SignatureConfirm.Size = new System.Drawing.Size(110, 13);
            this.label3SignatureConfirm.TabIndex = 33;
            this.label3SignatureConfirm.Text = "Ar tvirtinamas parasas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Zinute is paraso";
            // 
            // richTextBox3MessageFromSignature
            // 
            this.richTextBox3MessageFromSignature.Location = new System.Drawing.Point(2, 189);
            this.richTextBox3MessageFromSignature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox3MessageFromSignature.Name = "richTextBox3MessageFromSignature";
            this.richTextBox3MessageFromSignature.ReadOnly = true;
            this.richTextBox3MessageFromSignature.Size = new System.Drawing.Size(181, 66);
            this.richTextBox3MessageFromSignature.TabIndex = 31;
            this.richTextBox3MessageFromSignature.Text = "";
            // 
            // label3KeyPublic
            // 
            this.label3KeyPublic.AutoSize = true;
            this.label3KeyPublic.Location = new System.Drawing.Point(2, 266);
            this.label3KeyPublic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3KeyPublic.Name = "label3KeyPublic";
            this.label3KeyPublic.Size = new System.Drawing.Size(70, 13);
            this.label3KeyPublic.TabIndex = 30;
            this.label3KeyPublic.Text = "Viesas raktas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Zinute";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Zinute";
            // 
            // richTextBox3Message
            // 
            this.richTextBox3Message.Location = new System.Drawing.Point(2, 22);
            this.richTextBox3Message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox3Message.Name = "richTextBox3Message";
            this.richTextBox3Message.ReadOnly = true;
            this.richTextBox3Message.Size = new System.Drawing.Size(181, 66);
            this.richTextBox3Message.TabIndex = 27;
            this.richTextBox3Message.Text = "";
            // 
            // richTextBox3Signature
            // 
            this.richTextBox3Signature.Location = new System.Drawing.Point(2, 106);
            this.richTextBox3Signature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox3Signature.Name = "richTextBox3Signature";
            this.richTextBox3Signature.ReadOnly = true;
            this.richTextBox3Signature.Size = new System.Drawing.Size(181, 66);
            this.richTextBox3Signature.TabIndex = 28;
            this.richTextBox3Signature.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 433);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1Plaintext;
        private System.Windows.Forms.Button button1Send;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1P;
        private System.Windows.Forms.ComboBox comboBox1Q;
        private System.Windows.Forms.RichTextBox richTextBox1Ciphertext;
        private System.Windows.Forms.Label label1KeyPrivate;
        private System.Windows.Forms.Label label1KeyPublic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2Send;
        private System.Windows.Forms.RichTextBox richTextBox2Signature;
        private System.Windows.Forms.RichTextBox richTextBox2Message;
        private System.Windows.Forms.Label label2KeyPublic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox3MessageFromSignature;
        private System.Windows.Forms.Label label3KeyPublic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox3Message;
        private System.Windows.Forms.RichTextBox richTextBox3Signature;
        private System.Windows.Forms.Label label3SignatureConfirm;
    }
}

