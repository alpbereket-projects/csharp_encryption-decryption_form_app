﻿namespace Encryption_Decryption
{
    partial class SezarSifreCozucu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SezarSifreCozucu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.şifreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programdanÇıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDesifreEdilenYazi = new System.Windows.Forms.RichTextBox();
            this.buton2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYaziSifre = new System.Windows.Forms.RichTextBox();
            this.buton1 = new System.Windows.Forms.Button();
            this.txtAnahtarSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreleToolStripMenuItem,
            this.programdanÇıkToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // şifreleToolStripMenuItem
            // 
            this.şifreleToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.şifreleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifreleToolStripMenuItem.ForeColor = System.Drawing.Color.GhostWhite;
            this.şifreleToolStripMenuItem.Name = "şifreleToolStripMenuItem";
            this.şifreleToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.şifreleToolStripMenuItem.Text = "Şifrele";
            this.şifreleToolStripMenuItem.Click += new System.EventHandler(this.şifreleToolStripMenuItem_Click);
            // 
            // programdanÇıkToolStripMenuItem
            // 
            this.programdanÇıkToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.programdanÇıkToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.programdanÇıkToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.programdanÇıkToolStripMenuItem.ForeColor = System.Drawing.Color.GhostWhite;
            this.programdanÇıkToolStripMenuItem.Name = "programdanÇıkToolStripMenuItem";
            this.programdanÇıkToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.programdanÇıkToolStripMenuItem.Text = "Programdan Çık";
            this.programdanÇıkToolStripMenuItem.Click += new System.EventHandler(this.programdanÇıkToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.RoyalBlue;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.GhostWhite;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 20);
            this.toolStripMenuItem1.Text = "Şifreleme araçlarına geri dön";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtDesifreEdilenYazi);
            this.groupBox2.Controls.Add(this.buton2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Location = new System.Drawing.Point(13, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuç";
            // 
            // txtDesifreEdilenYazi
            // 
            this.txtDesifreEdilenYazi.BackColor = System.Drawing.Color.Gray;
            this.txtDesifreEdilenYazi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDesifreEdilenYazi.Location = new System.Drawing.Point(135, 43);
            this.txtDesifreEdilenYazi.Name = "txtDesifreEdilenYazi";
            this.txtDesifreEdilenYazi.Size = new System.Drawing.Size(370, 109);
            this.txtDesifreEdilenYazi.TabIndex = 4;
            this.txtDesifreEdilenYazi.Text = "";
            // 
            // buton2
            // 
            this.buton2.BackColor = System.Drawing.Color.DarkOrange;
            this.buton2.ForeColor = System.Drawing.Color.GhostWhite;
            this.buton2.Location = new System.Drawing.Point(278, 158);
            this.buton2.Name = "buton2";
            this.buton2.Size = new System.Drawing.Size(92, 35);
            this.buton2.TabIndex = 3;
            this.buton2.Text = "Temizle";
            this.buton2.UseVisualStyleBackColor = false;
            this.buton2.Click += new System.EventHandler(this.buton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(260, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Çözülen değer : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtYaziSifre);
            this.groupBox1.Controls.Add(this.buton1);
            this.groupBox1.Controls.Add(this.txtAnahtarSayi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(13, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 207);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çözülecek";
            // 
            // txtYaziSifre
            // 
            this.txtYaziSifre.BackColor = System.Drawing.Color.Gray;
            this.txtYaziSifre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtYaziSifre.Location = new System.Drawing.Point(135, 103);
            this.txtYaziSifre.Name = "txtYaziSifre";
            this.txtYaziSifre.Size = new System.Drawing.Size(370, 64);
            this.txtYaziSifre.TabIndex = 4;
            this.txtYaziSifre.Text = "";
            // 
            // buton1
            // 
            this.buton1.BackColor = System.Drawing.Color.DarkOrange;
            this.buton1.ForeColor = System.Drawing.Color.GhostWhite;
            this.buton1.Location = new System.Drawing.Point(278, 169);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(92, 35);
            this.buton1.TabIndex = 2;
            this.buton1.Text = "Çöz";
            this.buton1.UseVisualStyleBackColor = false;
            this.buton1.Click += new System.EventHandler(this.buton1_Click);
            // 
            // txtAnahtarSayi
            // 
            this.txtAnahtarSayi.BackColor = System.Drawing.Color.Gray;
            this.txtAnahtarSayi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAnahtarSayi.Location = new System.Drawing.Point(135, 43);
            this.txtAnahtarSayi.Name = "txtAnahtarSayi";
            this.txtAnahtarSayi.Size = new System.Drawing.Size(370, 26);
            this.txtAnahtarSayi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(218, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çözülecek değeri giriniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(229, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anahtar değeri giriniz :";
            // 
            // SezarSifreCozucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 518);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SezarSifreCozucu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sezar Şifre Çözücü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem şifreleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtDesifreEdilenYazi;
        private System.Windows.Forms.Button buton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtYaziSifre;
        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.TextBox txtAnahtarSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem programdanÇıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}