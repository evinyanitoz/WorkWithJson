namespace WorkWithJson
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtAdres = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "ADI ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 34);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "SOYADI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 30);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "ADRES";
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.Window;
            txtAd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.ForeColor = SystemColors.MenuText;
            txtAd.Location = new Point(26, 18);
            txtAd.Margin = new Padding(4, 3, 4, 3);
            txtAd.Multiline = true;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(129, 31);
            txtAd.TabIndex = 8;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.Window;
            txtSoyad.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.ForeColor = SystemColors.MenuText;
            txtSoyad.Location = new Point(208, 18);
            txtSoyad.Margin = new Padding(4, 3, 4, 3);
            txtSoyad.Multiline = true;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(129, 31);
            txtSoyad.TabIndex = 10;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = SystemColors.Window;
            txtAdres.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAdres.ForeColor = SystemColors.InfoText;
            txtAdres.Location = new Point(395, 18);
            txtAdres.Margin = new Padding(4, 3, 4, 3);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(129, 31);
            txtAdres.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(532, 2);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(79, 49);
            button1.TabIndex = 12;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 57);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(698, 406);
            dataGridView1.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(619, 2);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(69, 49);
            button2.TabIndex = 14;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(701, 465);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtAdres);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button button2;
    }

    
    
}
