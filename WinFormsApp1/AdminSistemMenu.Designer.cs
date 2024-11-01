namespace WinFormsApp1
{
    partial class AdminSistemMenu
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
            ogrtmn_button = new Button();
            randomogrbutton = new Button();
            ikinciasamabutton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Location = new Point(124, 111);
            button1.Name = "button1";
            button1.Size = new Size(144, 63);
            button1.TabIndex = 0;
            button1.Text = "ÖĞRENCİ GÜNCELLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ogrtmn_button
            // 
            ogrtmn_button.BackColor = Color.Violet;
            ogrtmn_button.Location = new Point(124, 221);
            ogrtmn_button.Name = "ogrtmn_button";
            ogrtmn_button.Size = new Size(144, 63);
            ogrtmn_button.TabIndex = 1;
            ogrtmn_button.Text = "ÖĞRETMEN GÜNCELLE";
            ogrtmn_button.UseVisualStyleBackColor = false;
            ogrtmn_button.Click += ogrtmn_button_Click;
            // 
            // randomogrbutton
            // 
            randomogrbutton.BackColor = Color.Violet;
            randomogrbutton.Location = new Point(124, 341);
            randomogrbutton.Name = "randomogrbutton";
            randomogrbutton.Size = new Size(144, 63);
            randomogrbutton.TabIndex = 2;
            randomogrbutton.Text = "RANDOM ÖĞRENCİ EKLE";
            randomogrbutton.UseVisualStyleBackColor = false;
            randomogrbutton.Click += randomogrbutton_Click;
            // 
            // ikinciasamabutton
            // 
            ikinciasamabutton.BackColor = Color.Violet;
            ikinciasamabutton.Location = new Point(501, 341);
            ikinciasamabutton.Name = "ikinciasamabutton";
            ikinciasamabutton.Size = new Size(144, 63);
            ikinciasamabutton.TabIndex = 3;
            ikinciasamabutton.Text = "İKİNCİ AŞAMAYA GEÇ";
            ikinciasamabutton.UseVisualStyleBackColor = false;
            ikinciasamabutton.Click += ikinciasamabutton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Violet;
            button2.Location = new Point(501, 111);
            button2.Name = "button2";
            button2.Size = new Size(144, 63);
            button2.TabIndex = 4;
            button2.Text = "ÖĞRENCİYE DERS EKLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AdminSistemMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(ikinciasamabutton);
            Controls.Add(randomogrbutton);
            Controls.Add(ogrtmn_button);
            Controls.Add(button1);
            Name = "AdminSistemMenu";
            Text = "AdminSistemMenu";
            Load += AdminSistemMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button ogrtmn_button;
        private Button randomogrbutton;
        private Button ikinciasamabutton;
        private Button button2;
    }
}