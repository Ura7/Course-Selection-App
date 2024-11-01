namespace WinFormsApp1
{
    partial class AdminSistem
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(207, 35);
            label1.Name = "label1";
            label1.Size = new Size(314, 50);
            label1.TabIndex = 15;
            label1.Text = "ADMİN SİSTEMİ ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 267);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 23);
            textBox2.TabIndex = 14;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 23);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(518, 321);
            button1.Name = "button1";
            button1.Size = new Size(156, 94);
            button1.TabIndex = 12;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(150, 321);
            button2.Name = "button2";
            button2.Size = new Size(156, 94);
            button2.TabIndex = 11;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(127, 250);
            label3.Name = "label3";
            label3.Size = new Size(187, 40);
            label3.TabIndex = 10;
            label3.Text = "PASSWORD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(127, 158);
            label2.Name = "label2";
            label2.Size = new Size(179, 40);
            label2.TabIndex = 9;
            label2.Text = "USERNAME:";
            // 
            // AdminSistem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AdminSistem";
            Text = "AdminSistem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label2;
    }
}