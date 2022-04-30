
namespace RSA
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
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fresh = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_savetodb = new System.Windows.Forms.Button();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_rinktisdb = new System.Windows.Forms.Button();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_fi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(29, 103);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(187, 22);
            this.textBox_p.TabIndex = 0;
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(29, 136);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(187, 22);
            this.textBox_q.TabIndex = 1;
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(29, 329);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(100, 37);
            this.button_encrypt.TabIndex = 2;
            this.button_encrypt.Text = "encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "q";
            // 
            // textBox_fresh
            // 
            this.textBox_fresh.Location = new System.Drawing.Point(29, 169);
            this.textBox_fresh.Multiline = true;
            this.textBox_fresh.Name = "textBox_fresh";
            this.textBox_fresh.Size = new System.Drawing.Size(369, 154);
            this.textBox_fresh.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // button_decrypt
            // 
            this.button_decrypt.Location = new System.Drawing.Point(298, 329);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(100, 37);
            this.button_decrypt.TabIndex = 7;
            this.button_decrypt.Text = "decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(579, 169);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(384, 154);
            this.textBox_result.TabIndex = 8;
            // 
            // button_savetodb
            // 
            this.button_savetodb.Location = new System.Drawing.Point(766, 329);
            this.button_savetodb.Name = "button_savetodb";
            this.button_savetodb.Size = new System.Drawing.Size(197, 33);
            this.button_savetodb.TabIndex = 9;
            this.button_savetodb.Text = "Išsaugoti į Duomenų bazę";
            this.button_savetodb.UseVisualStyleBackColor = true;
            this.button_savetodb.Click += new System.EventHandler(this.button_savetodb_Click);
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(579, 103);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.ReadOnly = true;
            this.textBox_e.Size = new System.Drawing.Size(185, 22);
            this.textBox_e.TabIndex = 10;
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(579, 131);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.ReadOnly = true;
            this.textBox_d.Size = new System.Drawing.Size(185, 22);
            this.textBox_d.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "e";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "d";
            // 
            // button_rinktisdb
            // 
            this.button_rinktisdb.Location = new System.Drawing.Point(191, 11);
            this.button_rinktisdb.Name = "button_rinktisdb";
            this.button_rinktisdb.Size = new System.Drawing.Size(84, 25);
            this.button_rinktisdb.TabIndex = 14;
            this.button_rinktisdb.Text = "Rinktis";
            this.button_rinktisdb.UseVisualStyleBackColor = true;
            this.button_rinktisdb.Click += new System.EventHandler(this.button_rinktisdb_Click);
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(579, 75);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.ReadOnly = true;
            this.textBox_n.Size = new System.Drawing.Size(185, 22);
            this.textBox_n.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "n";
            // 
            // textBox_fi
            // 
            this.textBox_fi.Location = new System.Drawing.Point(579, 47);
            this.textBox_fi.Name = "textBox_fi";
            this.textBox_fi.ReadOnly = true;
            this.textBox_fi.Size = new System.Drawing.Size(185, 22);
            this.textBox_fi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "fi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 399);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_fi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.button_rinktisdb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.button_savetodb);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_fresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_p);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_savetodb;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_rinktisdb;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_fi;
        private System.Windows.Forms.Label label6;
    }
}

