namespace WinFormsApp1
{
    partial class OgretmenogrenciGoruntule
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
            ogr_listele_Button = new Button();
            label4 = new Label();
            derseklemeistegi_button = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            notsirala_button = new Button();
            label1 = new Label();
            ogr_goruntule = new DataGridView();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ogr_goruntule).BeginInit();
            SuspendLayout();
            // 
            // ogr_listele_Button
            // 
            ogr_listele_Button.Location = new Point(624, 24);
            ogr_listele_Button.Name = "ogr_listele_Button";
            ogr_listele_Button.Size = new Size(137, 23);
            ogr_listele_Button.TabIndex = 1;
            ogr_listele_Button.Text = "Öğrenci Listele";
            ogr_listele_Button.UseVisualStyleBackColor = true;
            ogr_listele_Button.Click += ogr_listele_Button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 247);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 17;
            label4.Text = "DERS NUMARASI  :";
            // 
            // derseklemeistegi_button
            // 
            derseklemeistegi_button.Location = new Point(682, 296);
            derseklemeistegi_button.Name = "derseklemeistegi_button";
            derseklemeistegi_button.Size = new Size(128, 23);
            derseklemeistegi_button.TabIndex = 16;
            derseklemeistegi_button.Text = "DERS EKLEME İSTEĞİ";
            derseklemeistegi_button.UseVisualStyleBackColor = true;
            derseklemeistegi_button.Click += derseklemeistegi_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(721, 149);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 14;
            label3.Text = "ÖĞRENCİYE DERS EKLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 90);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 13;
            label2.Text = "ARAMA  :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(418, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // notsirala_button
            // 
            notsirala_button.Location = new Point(194, 496);
            notsirala_button.Name = "notsirala_button";
            notsirala_button.Size = new Size(131, 23);
            notsirala_button.TabIndex = 11;
            notsirala_button.Text = "NOTLARINI SIRALA";
            notsirala_button.UseVisualStyleBackColor = true;
            notsirala_button.Click += notsirala_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 87);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 10;
            label1.Text = "ÖĞRENCİNİN DERSLERİ";
            // 
            // ogr_goruntule
            // 
            ogr_goruntule.AccessibleName = "ogr_goruntule";
            ogr_goruntule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ogr_goruntule.Location = new Point(0, 114);
            ogr_goruntule.Name = "ogr_goruntule";
            ogr_goruntule.RowTemplate.Height = 25;
            ogr_goruntule.Size = new Size(545, 376);
            ogr_goruntule.TabIndex = 9;
            ogr_goruntule.CellContentClick += ogr_goruntule_CellContentClick;
            ogr_goruntule.DoubleClick += ogr_goruntule_DoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 209);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 18;
            label5.Text = "ÖĞRENCİ NUMARASI  :";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(721, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 23);
            comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(721, 247);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 23);
            comboBox2.TabIndex = 20;
            // 
            // OgretmenogrenciGoruntule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(927, 606);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(derseklemeistegi_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(notsirala_button);
            Controls.Add(label1);
            Controls.Add(ogr_goruntule);
            Controls.Add(ogr_listele_Button);
            Name = "OgretmenogrenciGoruntule";
            Text = "OgretmenogrenciGoruntule";
            Load += OgretmenogrenciGoruntule_Load;
            ((System.ComponentModel.ISupportInitialize)ogr_goruntule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ogr_listele_Button;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Button notsirala_button;
        private Label label1;
        internal DataGridView ogr_goruntule;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        internal Button derseklemeistegi_button;
    }
}