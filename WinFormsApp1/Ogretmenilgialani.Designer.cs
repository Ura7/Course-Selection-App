namespace WinFormsApp1
{
    partial class Ogretmenilgialani
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
            ilgialani_textBox = new TextBox();
            iglialaniekle_button = new Button();
            SuspendLayout();
            // 
            // ilgialani_textBox
            // 
            ilgialani_textBox.Location = new Point(36, 152);
            ilgialani_textBox.Name = "ilgialani_textBox";
            ilgialani_textBox.Size = new Size(257, 23);
            ilgialani_textBox.TabIndex = 0;
            // 
            // iglialaniekle_button
            // 
            iglialaniekle_button.Location = new Point(78, 202);
            iglialaniekle_button.Name = "iglialaniekle_button";
            iglialaniekle_button.Size = new Size(160, 23);
            iglialaniekle_button.TabIndex = 1;
            iglialaniekle_button.Text = "İLGİ ALANLARINA EKLE";
            iglialaniekle_button.UseVisualStyleBackColor = true;
            iglialaniekle_button.Click += iglialaniekle_button_Click;
            // 
            // Ogretmenilgialani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(334, 450);
            Controls.Add(iglialaniekle_button);
            Controls.Add(ilgialani_textBox);
            Name = "Ogretmenilgialani";
            Text = "Ogretmenilgialani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ilgialani_textBox;
        private Button iglialaniekle_button;
    }
}