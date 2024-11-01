namespace WinFormsApp1
{
    partial class AdminOgrenciguncelleDevam
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
            guncelle_button = new Button();
            delete_button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxNO = new TextBox();
            textBoxisim = new TextBox();
            textBoxsoyisim = new TextBox();
            textBoxdurum = new TextBox();
            textBoxsifre = new TextBox();
            textBoxilgi = new TextBox();
            ogrekle_button = new Button();
            SuspendLayout();
            // 
            // guncelle_button
            // 
            guncelle_button.BackColor = Color.Gold;
            guncelle_button.Location = new Point(58, 435);
            guncelle_button.Name = "guncelle_button";
            guncelle_button.Size = new Size(133, 55);
            guncelle_button.TabIndex = 0;
            guncelle_button.Text = "GÜNCELLE";
            guncelle_button.UseVisualStyleBackColor = false;
            guncelle_button.Click += guncelle_button_Click;
            // 
            // delete_button
            // 
            delete_button.BackColor = Color.Gold;
            delete_button.Location = new Point(230, 435);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(133, 55);
            delete_button.TabIndex = 1;
            delete_button.Text = "SİL";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(28, 48);
            label1.Name = "label1";
            label1.Size = new Size(88, 16);
            label1.TabIndex = 2;
            label1.Text = "ÖĞRENCİ NO  :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(28, 93);
            label2.Name = "label2";
            label2.Size = new Size(39, 16);
            label2.TabIndex = 3;
            label2.Text = "İSİM  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(28, 136);
            label3.Name = "label3";
            label3.Size = new Size(61, 16);
            label3.TabIndex = 4;
            label3.Text = "SOYİSİM  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(28, 179);
            label4.Name = "label4";
            label4.Size = new Size(58, 16);
            label4.TabIndex = 5;
            label4.Text = "DURUM  :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(28, 265);
            label5.Name = "label5";
            label5.Size = new Size(73, 16);
            label5.TabIndex = 6;
            label5.Text = "İLGİ ALANI  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(28, 223);
            label6.Name = "label6";
            label6.Size = new Size(46, 16);
            label6.TabIndex = 7;
            label6.Text = "ŞİFRE  :";
            // 
            // textBoxNO
            // 
            textBoxNO.Location = new Point(133, 46);
            textBoxNO.Name = "textBoxNO";
            textBoxNO.Size = new Size(262, 23);
            textBoxNO.TabIndex = 8;
            // 
            // textBoxisim
            // 
            textBoxisim.Location = new Point(133, 93);
            textBoxisim.Name = "textBoxisim";
            textBoxisim.Size = new Size(262, 23);
            textBoxisim.TabIndex = 9;
            // 
            // textBoxsoyisim
            // 
            textBoxsoyisim.Location = new Point(133, 136);
            textBoxsoyisim.Name = "textBoxsoyisim";
            textBoxsoyisim.Size = new Size(262, 23);
            textBoxsoyisim.TabIndex = 10;
            // 
            // textBoxdurum
            // 
            textBoxdurum.Location = new Point(133, 179);
            textBoxdurum.Name = "textBoxdurum";
            textBoxdurum.Size = new Size(262, 23);
            textBoxdurum.TabIndex = 11;
            // 
            // textBoxsifre
            // 
            textBoxsifre.Location = new Point(133, 223);
            textBoxsifre.Name = "textBoxsifre";
            textBoxsifre.Size = new Size(262, 23);
            textBoxsifre.TabIndex = 12;
            // 
            // textBoxilgi
            // 
            textBoxilgi.Location = new Point(133, 263);
            textBoxilgi.Name = "textBoxilgi";
            textBoxilgi.Size = new Size(262, 23);
            textBoxilgi.TabIndex = 13;
            // 
            // ogrekle_button
            // 
            ogrekle_button.BackColor = Color.Gold;
            ogrekle_button.Location = new Point(145, 361);
            ogrekle_button.Name = "ogrekle_button";
            ogrekle_button.Size = new Size(133, 55);
            ogrekle_button.TabIndex = 14;
            ogrekle_button.Text = "EKLE";
            ogrekle_button.UseVisualStyleBackColor = false;
            ogrekle_button.Click += ogrekle_button_Click;
            // 
            // AdminOgrenciguncelleDevam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(440, 567);
            Controls.Add(ogrekle_button);
            Controls.Add(textBoxilgi);
            Controls.Add(textBoxsifre);
            Controls.Add(textBoxdurum);
            Controls.Add(textBoxsoyisim);
            Controls.Add(textBoxisim);
            Controls.Add(textBoxNO);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(delete_button);
            Controls.Add(guncelle_button);
            Name = "AdminOgrenciguncelleDevam";
            Text = "AdminOgrenciguncelleDevam";
            Load += AdminOgrenciguncelleDevam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guncelle_button;
        private Button delete_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        internal TextBox textBoxNO;
        internal TextBox textBoxisim;
        internal TextBox textBoxsoyisim;
        internal TextBox textBoxdurum;
        internal TextBox textBoxsifre;
        internal TextBox textBoxilgi;
        private Button ogrekle_button;
    }
}