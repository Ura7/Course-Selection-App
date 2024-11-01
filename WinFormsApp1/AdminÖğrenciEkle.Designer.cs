namespace WinFormsApp1
{
    partial class AdminÖğrenciEkle
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 78);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ NUMARASI  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 181);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "DERS ID  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 129);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 3;
            label4.Text = "ÖĞRETMEN SİCİL NO  :";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 23);
            comboBox1.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(166, 173);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(161, 23);
            comboBox3.TabIndex = 7;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(166, 126);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(161, 23);
            comboBox4.TabIndex = 8;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(95, 252);
            button1.Name = "button1";
            button1.Size = new Size(134, 41);
            button1.TabIndex = 10;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminÖğrenciEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(349, 492);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminÖğrenciEkle";
            Text = "AdminÖğrenciEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Button button1;
        internal ComboBox comboBox1;
        internal ComboBox comboBox3;
        internal ComboBox comboBox4;
    }
}