namespace deneme
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
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            Sigorta = new CheckBox();
            textId = new TextBox();
            textAdSoyad = new TextBox();
            textYas = new TextBox();
            dtTarih = new DateTimePicker();
            cmbBirim = new ComboBox();
            btnKaydet = new Button();
            btnSil = new Button();
            btnGüncelle = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 54);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 94);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 134);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "Tarih";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 174);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 4;
            label5.Text = "Birim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 214);
            label7.Name = "label7";
            label7.Size = new Size(30, 20);
            label7.TabIndex = 6;
            label7.Text = "Yaş";
            // 
            // Sigorta
            // 
            Sigorta.AutoSize = true;
            Sigorta.Location = new Point(119, 257);
            Sigorta.Name = "Sigorta";
            Sigorta.Size = new Size(87, 24);
            Sigorta.TabIndex = 7;
            Sigorta.Text = "Sigortalı";
            Sigorta.UseVisualStyleBackColor = true;
            // 
            // textId
            // 
            textId.Location = new Point(236, 54);
            textId.Name = "textId";
            textId.Size = new Size(255, 27);
            textId.TabIndex = 8;
            // 
            // textAdSoyad
            // 
            textAdSoyad.Location = new Point(236, 94);
            textAdSoyad.Name = "textAdSoyad";
            textAdSoyad.Size = new Size(255, 27);
            textAdSoyad.TabIndex = 9;
            // 
            // textYas
            // 
            textYas.Location = new Point(236, 214);
            textYas.Name = "textYas";
            textYas.Size = new Size(255, 27);
            textYas.TabIndex = 10;
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(236, 132);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(255, 27);
            dtTarih.TabIndex = 11;
            // 
            // cmbBirim
            // 
            cmbBirim.FormattingEnabled = true;
            cmbBirim.Items.AddRange(new object[] { "Dahiliye", "KBB", "Göz" });
            cmbBirim.Location = new Point(236, 174);
            cmbBirim.Name = "cmbBirim";
            cmbBirim.Size = new Size(255, 28);
            cmbBirim.TabIndex = 12;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(535, 54);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 56);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(535, 119);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 56);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(535, 185);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(94, 56);
            btnGüncelle.TabIndex = 15;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(754, 147);
            dataGridView1.TabIndex = 16;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += btnKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(dataGridView1);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(cmbBirim);
            Controls.Add(dtTarih);
            Controls.Add(textYas);
            Controls.Add(textAdSoyad);
            Controls.Add(textId);
            Controls.Add(Sigorta);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private CheckBox Sigorta;
        private TextBox textId;
        private TextBox textAdSoyad;
        private TextBox textYas;
        private DateTimePicker dtTarih;
        private ComboBox cmbBirim;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnGüncelle;
        private DataGridView dataGridView1;
    }
}
