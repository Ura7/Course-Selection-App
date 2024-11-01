namespace WinFormsApp1
{
    partial class OgenciDersSec
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
            dersec_grid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            derssecsicil_text = new TextBox();
            derssecDersno_text = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dersec_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dersec_grid
            // 
            dersec_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dersec_grid.Location = new Point(0, 36);
            dersec_grid.Name = "dersec_grid";
            dersec_grid.RowTemplate.Height = 25;
            dersec_grid.Size = new Size(415, 246);
            dersec_grid.TabIndex = 0;
            dersec_grid.DoubleClick += dersec_grid_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 44);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "ÖĞRETMEN SİCİL NO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 88);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "DERS NUMARASI: ";
            // 
            // derssecsicil_text
            // 
            derssecsicil_text.Location = new Point(596, 36);
            derssecsicil_text.Name = "derssecsicil_text";
            derssecsicil_text.Size = new Size(100, 23);
            derssecsicil_text.TabIndex = 3;
            // 
            // derssecDersno_text
            // 
            derssecDersno_text.Location = new Point(596, 80);
            derssecDersno_text.Name = "derssecDersno_text";
            derssecDersno_text.Size = new Size(100, 23);
            derssecDersno_text.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(470, 139);
            button1.Name = "button1";
            button1.Size = new Size(214, 32);
            button1.TabIndex = 5;
            button1.Text = "DERSİ EKLEME BAŞVURUSU";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 380);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 6;
            label3.Text = "ÖĞRETMEN SİCİL NO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 423);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 7;
            label4.Text = "DERS NUMARASI: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(596, 377);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(596, 415);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(470, 470);
            button2.Name = "button2";
            button2.Size = new Size(214, 32);
            button2.TabIndex = 10;
            button2.Text = "BAŞVURUYU İPTAL ET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 339);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(415, 246);
            dataGridView1.TabIndex = 11;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 9);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 12;
            label5.Text = "AÇILAN DERSLER LİSTESİ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(134, 305);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 13;
            label6.Text = "BAŞVURULARIM";
            // 
            // OgenciDersSec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(772, 597);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(derssecDersno_text);
            Controls.Add(derssecsicil_text);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dersec_grid);
            Name = "OgenciDersSec";
            Text = "OgenciDersSec";
            ((System.ComponentModel.ISupportInitialize)dersec_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal DataGridView dersec_grid;
        private Label label1;
        private Label label2;
        private TextBox derssecsicil_text;
        private TextBox derssecDersno_text;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label5;
        private Label label6;
        internal DataGridView dataGridView1;
    }
}