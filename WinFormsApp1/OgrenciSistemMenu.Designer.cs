namespace WinFormsApp1
{
    partial class OgrenciSistemMenu
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
            button2 = new Button();
            transkript_Button = new Button();
            ogrbilgi_button = new Button();
            derssec_button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(138, 265);
            button2.Name = "button2";
            button2.Size = new Size(138, 55);
            button2.TabIndex = 0;
            button2.Text = "DERS LİSTESİ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // transkript_Button
            // 
            transkript_Button.BackColor = Color.IndianRed;
            transkript_Button.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            transkript_Button.Location = new Point(138, 145);
            transkript_Button.Name = "transkript_Button";
            transkript_Button.Size = new Size(138, 55);
            transkript_Button.TabIndex = 1;
            transkript_Button.Text = "  TRANSKRİPT     YÜKLE";
            transkript_Button.UseVisualStyleBackColor = false;
            transkript_Button.Click += transkript_Button_Click;
            // 
            // ogrbilgi_button
            // 
            ogrbilgi_button.BackColor = Color.IndianRed;
            ogrbilgi_button.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ogrbilgi_button.Location = new Point(473, 145);
            ogrbilgi_button.Name = "ogrbilgi_button";
            ogrbilgi_button.Size = new Size(138, 55);
            ogrbilgi_button.TabIndex = 2;
            ogrbilgi_button.Text = "BİLGİLERİM";
            ogrbilgi_button.UseVisualStyleBackColor = false;
            ogrbilgi_button.Click += ogrbilgi_button_Click;
            // 
            // derssec_button
            // 
            derssec_button.BackColor = Color.IndianRed;
            derssec_button.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            derssec_button.Location = new Point(473, 265);
            derssec_button.Name = "derssec_button";
            derssec_button.Size = new Size(138, 55);
            derssec_button.TabIndex = 3;
            derssec_button.Text = "DERS SEÇİMİ";
            derssec_button.UseVisualStyleBackColor = false;
            derssec_button.Click += derssec_button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(302, 36);
            button1.Name = "button1";
            button1.Size = new Size(138, 55);
            button1.TabIndex = 4;
            button1.Text = "MESAJLARIM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // OgrenciSistemMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(derssec_button);
            Controls.Add(ogrbilgi_button);
            Controls.Add(transkript_Button);
            Controls.Add(button2);
            Name = "OgrenciSistemMenu";
            Text = "OgrenciSistemMenu";
            Load += OgrenciSistemMenu_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button transkript_Button;
        private Button ogrbilgi_button;
        private Button derssec_button;
        private Button button1;
    }
}