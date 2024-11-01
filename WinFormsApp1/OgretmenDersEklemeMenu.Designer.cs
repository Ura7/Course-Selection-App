namespace WinFormsApp1
{
    partial class OgretmenDersEklemeMenu
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
            dataGridView_istek = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_istek).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_istek
            // 
            dataGridView_istek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_istek.Location = new Point(0, 27);
            dataGridView_istek.Name = "dataGridView_istek";
            dataGridView_istek.RowTemplate.Height = 25;
            dataGridView_istek.Size = new Size(391, 411);
            dataGridView_istek.TabIndex = 0;
            dataGridView_istek.CellContentClick += dataGridView_istek_CellContentClick;
            dataGridView_istek.DoubleClick += dataGridView_istek_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 1;
            label1.Text = "DERS EKLEME İSTEKLERİ";
            // 
            // button1
            // 
            button1.Location = new Point(580, 85);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OgretmenDersEklemeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView_istek);
            Name = "OgretmenDersEklemeMenu";
            Text = "OgretmenDersEklemeMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridView_istek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        internal DataGridView dataGridView_istek;
        private Button button1;
    }
}