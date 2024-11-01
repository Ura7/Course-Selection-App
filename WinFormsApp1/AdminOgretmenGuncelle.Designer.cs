namespace WinFormsApp1
{
    partial class AdminOgretmenGuncelle
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
            ogretmen_data = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ogretmen_data).BeginInit();
            SuspendLayout();
            // 
            // ogretmen_data
            // 
            ogretmen_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ogretmen_data.Location = new Point(1, 0);
            ogretmen_data.Name = "ogretmen_data";
            ogretmen_data.RowTemplate.Height = 25;
            ogretmen_data.Size = new Size(800, 452);
            ogretmen_data.TabIndex = 0;
            ogretmen_data.CellContentClick += ogretmen_data_CellContentClick;
            ogretmen_data.DoubleClick += ogretmen_data_DoubleClick;
            // 
            // AdminOgretmenGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ogretmen_data);
            Name = "AdminOgretmenGuncelle";
            Text = "AdminOgretmenGuncelle";
            ((System.ComponentModel.ISupportInitialize)ogretmen_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView ogretmen_data;
    }
}