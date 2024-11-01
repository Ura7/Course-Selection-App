namespace WinFormsApp1
{
    partial class AdminOgrenciGuncelle
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
            adminogr_data = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)adminogr_data).BeginInit();
            SuspendLayout();
            // 
            // adminogr_data
            // 
            adminogr_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminogr_data.Location = new Point(0, 0);
            adminogr_data.Name = "adminogr_data";
            adminogr_data.RowTemplate.Height = 25;
            adminogr_data.Size = new Size(575, 449);
            adminogr_data.TabIndex = 0;
            adminogr_data.DoubleClick += dataGridView1_DoubleClick;
            // 
            // AdminOgrenciGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(adminogr_data);
            Name = "AdminOgrenciGuncelle";
            Text = "AdminOgrenciGuncelle";
            ((System.ComponentModel.ISupportInitialize)adminogr_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView adminogr_data;
    }
}