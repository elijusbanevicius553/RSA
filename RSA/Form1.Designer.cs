﻿
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
            this.textBox_test = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(139, 94);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(100, 22);
            this.textBox_p.TabIndex = 0;
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(139, 145);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(100, 22);
            this.textBox_q.TabIndex = 1;
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(29, 379);
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
            this.label1.Location = new System.Drawing.Point(104, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "q";
            // 
            // textBox_fresh
            // 
            this.textBox_fresh.Location = new System.Drawing.Point(29, 214);
            this.textBox_fresh.Multiline = true;
            this.textBox_fresh.Name = "textBox_fresh";
            this.textBox_fresh.Size = new System.Drawing.Size(369, 115);
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
            this.button_decrypt.Location = new System.Drawing.Point(298, 379);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(100, 37);
            this.button_decrypt.TabIndex = 7;
            this.button_decrypt.Text = "decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(579, 214);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(384, 115);
            this.textBox_result.TabIndex = 8;
            // 
            // button_savetodb
            // 
            this.button_savetodb.Location = new System.Drawing.Point(766, 335);
            this.button_savetodb.Name = "button_savetodb";
            this.button_savetodb.Size = new System.Drawing.Size(197, 33);
            this.button_savetodb.TabIndex = 9;
            this.button_savetodb.Text = "Išsaugoti į Duomenų bazę";
            this.button_savetodb.UseVisualStyleBackColor = true;
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(579, 42);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(100, 22);
            this.textBox_e.TabIndex = 10;
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(579, 70);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(100, 22);
            this.textBox_d.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "e";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "d";
            // 
            // textBox_test
            // 
            this.textBox_test.Location = new System.Drawing.Point(579, 394);
            this.textBox_test.Name = "textBox_test";
            this.textBox_test.Size = new System.Drawing.Size(244, 22);
            this.textBox_test.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_test);
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
        private System.Windows.Forms.TextBox textBox_test;
        private System.Windows.Forms.Button button1;
    }
}

