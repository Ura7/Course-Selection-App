namespace WinFormsApp1
{
    partial class OgretmenKabulRet
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ OKUL NO  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "ÖĞRENCİ İSİM  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 2;
            label3.Text = "ÖĞRENCİ SOYİSİM  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(147, 15);
            label4.TabIndex = 3;
            label4.Text = "ÖĞRENCİ İLGİ ALANLARI  :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 42);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 82);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(151, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 122);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(151, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(171, 158);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(151, 23);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Location = new Point(38, 301);
            button1.Name = "button1";
            button1.Size = new Size(121, 62);
            button1.TabIndex = 8;
            button1.Text = "KABUL ET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(182, 301);
            button2.Name = "button2";
            button2.Size = new Size(121, 62);
            button2.TabIndex = 9;
            button2.Text = "REDDET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 200);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 10;
            label5.Text = "BAŞVURDUĞU DERS NO  :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(171, 197);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(151, 23);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 235);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 12;
            label6.Text = "BAŞVURDUĞU DERS  :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(171, 232);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(151, 23);
            textBox6.TabIndex = 13;
            // 
            // OgretmenKabulRet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(344, 450);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgretmenKabulRet";
            Text = "OgretmenKabulRet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        internal TextBox textBox1;
        internal TextBox textBox2;
        internal TextBox textBox3;
        internal TextBox textBox4;
        private Label label5;
        internal TextBox textBox5;
        private Label label6;
        internal TextBox textBox6;
    }
}