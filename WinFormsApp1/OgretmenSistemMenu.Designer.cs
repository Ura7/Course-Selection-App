﻿namespace WinFormsApp1
{
    partial class OgretmenSistemMenu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSpringGreen;
            button1.Location = new Point(120, 190);
            button1.Name = "button1";
            button1.Size = new Size(130, 56);
            button1.TabIndex = 0;
            button1.Text = "İLGİ ALANI GİR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSpringGreen;
            button2.Location = new Point(320, 190);
            button2.Name = "button2";
            button2.Size = new Size(130, 56);
            button2.TabIndex = 1;
            button2.Text = "ÖĞRENCİ GÖRÜNTÜLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSpringGreen;
            button3.Location = new Point(534, 190);
            button3.Name = "button3";
            button3.Size = new Size(130, 56);
            button3.TabIndex = 2;
            button3.Text = "Ders Ekleme";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSpringGreen;
            button4.Location = new Point(320, 32);
            button4.Name = "button4";
            button4.Size = new Size(130, 56);
            button4.TabIndex = 3;
            button4.Text = "MESAJLARIM";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // OgretmenSistemMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "OgretmenSistemMenu";
            Text = "OgretmenSistemMenu";
            Load += OgretmenSistemMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}