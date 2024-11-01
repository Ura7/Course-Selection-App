namespace WinFormsApp1
{
    partial class ÖğrenciBilgilerim
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
            dataGridViewbilgi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewbilgi).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewbilgi
            // 
            dataGridViewbilgi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewbilgi.Location = new Point(1, -1);
            dataGridViewbilgi.Name = "dataGridViewbilgi";
            dataGridViewbilgi.RowTemplate.Height = 25;
            dataGridViewbilgi.Size = new Size(342, 451);
            dataGridViewbilgi.TabIndex = 0;
            // 
            // ÖğrenciBilgilerim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 450);
            Controls.Add(dataGridViewbilgi);
            Name = "ÖğrenciBilgilerim";
            Text = "ÖğrenciBilgilerim";
            ((System.ComponentModel.ISupportInitialize)dataGridViewbilgi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView dataGridViewbilgi;
    }
}