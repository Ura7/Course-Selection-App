namespace WinFormsApp1
{
    partial class OgretmenSistem
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
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(111, 145);
            label2.Name = "label2";
            label2.Size = new Size(179, 40);
            label2.TabIndex = 2;
            label2.Text = "USERNAME:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(111, 237);
            label3.Name = "label3";
            label3.Size = new Size(187, 40);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD:";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(134, 308);
            button2.Name = "button2";
            button2.Size = new Size(156, 94);
            button2.TabIndex = 4;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(502, 308);
            button1.Name = "button1";
            button1.Size = new Size(156, 94);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(296, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(296, 254);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 23);
            textBox2.TabIndex = 7;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(191, 22);
            label1.Name = "label1";
            label1.Size = new Size(389, 50);
            label1.TabIndex = 8;
            label1.Text = "ÖĞRETMEN SİSTEMİ ";
            label1.Click += label1_Click;
            // 
            // OgretmenSistem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "OgretmenSistem";
            Text = "OgretmenSistem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
    }
}