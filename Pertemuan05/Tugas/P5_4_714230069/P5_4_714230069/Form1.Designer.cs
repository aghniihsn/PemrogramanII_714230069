namespace P5_4_714230069
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PilihanKelas = new System.Windows.Forms.GroupBox();
            this.Panahan = new System.Windows.Forms.CheckBox();
            this.Voli = new System.Windows.Forms.CheckBox();
            this.BuluTangkis = new System.Windows.Forms.CheckBox();
            this.Basket = new System.Windows.Forms.CheckBox();
            this.Yoga = new System.Windows.Forms.CheckBox();
            this.Tenis = new System.Windows.Forms.CheckBox();
            this.Renang = new System.Windows.Forms.CheckBox();
            this.SepakBola = new System.Windows.Forms.CheckBox();
            this.PilihanJadwal = new System.Windows.Forms.GroupBox();
            this.Minggu = new System.Windows.Forms.RadioButton();
            this.Sabtu = new System.Windows.Forms.RadioButton();
            this.Selasa = new System.Windows.Forms.RadioButton();
            this.Senin = new System.Windows.Forms.RadioButton();
            this.Tampilkan = new System.Windows.Forms.Button();
            this.Selesai = new System.Windows.Forms.Button();
            this.TanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.Nama = new System.Windows.Forms.TextBox();
            this.JenisKelamin = new System.Windows.Forms.ComboBox();
            this.PilihanKelas.SuspendLayout();
            this.PilihanJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(367, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PENDAFTARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir";
            // 
            // PilihanKelas
            // 
            this.PilihanKelas.Controls.Add(this.Panahan);
            this.PilihanKelas.Controls.Add(this.Voli);
            this.PilihanKelas.Controls.Add(this.BuluTangkis);
            this.PilihanKelas.Controls.Add(this.Basket);
            this.PilihanKelas.Controls.Add(this.Yoga);
            this.PilihanKelas.Controls.Add(this.Tenis);
            this.PilihanKelas.Controls.Add(this.Renang);
            this.PilihanKelas.Controls.Add(this.SepakBola);
            this.PilihanKelas.Location = new System.Drawing.Point(93, 215);
            this.PilihanKelas.Name = "PilihanKelas";
            this.PilihanKelas.Size = new System.Drawing.Size(319, 162);
            this.PilihanKelas.TabIndex = 4;
            this.PilihanKelas.TabStop = false;
            this.PilihanKelas.Text = "Pilihan kelas";
            this.PilihanKelas.Enter += new System.EventHandler(this.PilihanKelas_Enter);
            // 
            // Panahan
            // 
            this.Panahan.AutoSize = true;
            this.Panahan.Location = new System.Drawing.Point(156, 115);
            this.Panahan.Name = "Panahan";
            this.Panahan.Size = new System.Drawing.Size(83, 20);
            this.Panahan.TabIndex = 7;
            this.Panahan.Text = "Panahan";
            this.Panahan.UseVisualStyleBackColor = true;
            this.Panahan.CheckedChanged += new System.EventHandler(this.Panahan_CheckedChanged);
            // 
            // Voli
            // 
            this.Voli.AutoSize = true;
            this.Voli.Location = new System.Drawing.Point(156, 89);
            this.Voli.Name = "Voli";
            this.Voli.Size = new System.Drawing.Size(52, 20);
            this.Voli.TabIndex = 6;
            this.Voli.Text = "Voli";
            this.Voli.UseVisualStyleBackColor = true;
            this.Voli.CheckedChanged += new System.EventHandler(this.Voli_CheckedChanged);
            // 
            // BuluTangkis
            // 
            this.BuluTangkis.AutoSize = true;
            this.BuluTangkis.Location = new System.Drawing.Point(156, 63);
            this.BuluTangkis.Name = "BuluTangkis";
            this.BuluTangkis.Size = new System.Drawing.Size(101, 20);
            this.BuluTangkis.TabIndex = 5;
            this.BuluTangkis.Text = "Bulu tangkis";
            this.BuluTangkis.UseVisualStyleBackColor = true;
            this.BuluTangkis.CheckedChanged += new System.EventHandler(this.BuluTangkis_CheckedChanged);
            // 
            // Basket
            // 
            this.Basket.AutoSize = true;
            this.Basket.Location = new System.Drawing.Point(156, 37);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(71, 20);
            this.Basket.TabIndex = 4;
            this.Basket.Text = "Basket";
            this.Basket.UseVisualStyleBackColor = true;
            this.Basket.CheckedChanged += new System.EventHandler(this.Basket_CheckedChanged);
            // 
            // Yoga
            // 
            this.Yoga.AutoSize = true;
            this.Yoga.Location = new System.Drawing.Point(6, 115);
            this.Yoga.Name = "Yoga";
            this.Yoga.Size = new System.Drawing.Size(62, 20);
            this.Yoga.TabIndex = 3;
            this.Yoga.Text = "Yoga";
            this.Yoga.UseVisualStyleBackColor = true;
            this.Yoga.CheckedChanged += new System.EventHandler(this.Yoga_CheckedChanged);
            // 
            // Tenis
            // 
            this.Tenis.AutoSize = true;
            this.Tenis.Location = new System.Drawing.Point(6, 89);
            this.Tenis.Name = "Tenis";
            this.Tenis.Size = new System.Drawing.Size(63, 20);
            this.Tenis.TabIndex = 2;
            this.Tenis.Text = "Tenis";
            this.Tenis.UseVisualStyleBackColor = true;
            this.Tenis.CheckedChanged += new System.EventHandler(this.Tenis_CheckedChanged);
            // 
            // Renang
            // 
            this.Renang.AutoSize = true;
            this.Renang.Location = new System.Drawing.Point(6, 63);
            this.Renang.Name = "Renang";
            this.Renang.Size = new System.Drawing.Size(77, 20);
            this.Renang.TabIndex = 1;
            this.Renang.Text = "Renang";
            this.Renang.UseVisualStyleBackColor = true;
            this.Renang.CheckedChanged += new System.EventHandler(this.Renang_CheckedChanged);
            // 
            // SepakBola
            // 
            this.SepakBola.AutoSize = true;
            this.SepakBola.Location = new System.Drawing.Point(6, 37);
            this.SepakBola.Name = "SepakBola";
            this.SepakBola.Size = new System.Drawing.Size(100, 20);
            this.SepakBola.TabIndex = 0;
            this.SepakBola.Text = "Sepak Bola";
            this.SepakBola.UseVisualStyleBackColor = true;
            this.SepakBola.CheckedChanged += new System.EventHandler(this.SepakBola_CheckedChanged);
            // 
            // PilihanJadwal
            // 
            this.PilihanJadwal.Controls.Add(this.Minggu);
            this.PilihanJadwal.Controls.Add(this.Sabtu);
            this.PilihanJadwal.Controls.Add(this.Selasa);
            this.PilihanJadwal.Controls.Add(this.Senin);
            this.PilihanJadwal.Location = new System.Drawing.Point(444, 215);
            this.PilihanJadwal.Name = "PilihanJadwal";
            this.PilihanJadwal.Size = new System.Drawing.Size(342, 162);
            this.PilihanJadwal.TabIndex = 5;
            this.PilihanJadwal.TabStop = false;
            this.PilihanJadwal.Text = "Pilihan jadwal";
            this.PilihanJadwal.Enter += new System.EventHandler(this.PilihanJadwal_Enter);
            // 
            // Minggu
            // 
            this.Minggu.AutoSize = true;
            this.Minggu.Location = new System.Drawing.Point(7, 115);
            this.Minggu.Name = "Minggu";
            this.Minggu.Size = new System.Drawing.Size(144, 20);
            this.Minggu.TabIndex = 3;
            this.Minggu.TabStop = true;
            this.Minggu.Text = "Minggu, 13.00-20.00";
            this.Minggu.UseVisualStyleBackColor = true;
            this.Minggu.CheckedChanged += new System.EventHandler(this.Minggu_CheckedChanged);
            // 
            // Sabtu
            // 
            this.Sabtu.AutoSize = true;
            this.Sabtu.Location = new System.Drawing.Point(7, 89);
            this.Sabtu.Name = "Sabtu";
            this.Sabtu.Size = new System.Drawing.Size(200, 20);
            this.Sabtu.TabIndex = 2;
            this.Sabtu.TabStop = true;
            this.Sabtu.Text = "Sabtu s/d Minggu, 9.00-11.00 ";
            this.Sabtu.UseVisualStyleBackColor = true;
            this.Sabtu.CheckedChanged += new System.EventHandler(this.Rabu_CheckedChanged);
            // 
            // Selasa
            // 
            this.Selasa.AutoSize = true;
            this.Selasa.Location = new System.Drawing.Point(7, 62);
            this.Selasa.Name = "Selasa";
            this.Selasa.Size = new System.Drawing.Size(208, 20);
            this.Selasa.TabIndex = 1;
            this.Selasa.TabStop = true;
            this.Selasa.Text = "Selasa s/d Kamis, 14.00-16.00 ";
            this.Selasa.UseVisualStyleBackColor = true;
            this.Selasa.CheckedChanged += new System.EventHandler(this.Selasa_CheckedChanged);
            // 
            // Senin
            // 
            this.Senin.AutoSize = true;
            this.Senin.Location = new System.Drawing.Point(7, 36);
            this.Senin.Name = "Senin";
            this.Senin.Size = new System.Drawing.Size(195, 20);
            this.Senin.TabIndex = 0;
            this.Senin.TabStop = true;
            this.Senin.Text = "Senin s/d Rabu, 14.00-16.00 ";
            this.Senin.UseVisualStyleBackColor = true;
            this.Senin.CheckedChanged += new System.EventHandler(this.Senin_CheckedChanged);
            // 
            // Tampilkan
            // 
            this.Tampilkan.Location = new System.Drawing.Point(313, 413);
            this.Tampilkan.Name = "Tampilkan";
            this.Tampilkan.Size = new System.Drawing.Size(99, 23);
            this.Tampilkan.TabIndex = 6;
            this.Tampilkan.Text = "Tampilkan";
            this.Tampilkan.UseVisualStyleBackColor = true;
            this.Tampilkan.Click += new System.EventHandler(this.Tampilkan_Click);
            // 
            // Selesai
            // 
            this.Selesai.Location = new System.Drawing.Point(444, 413);
            this.Selesai.Name = "Selesai";
            this.Selesai.Size = new System.Drawing.Size(99, 23);
            this.Selesai.TabIndex = 7;
            this.Selesai.Text = "Selesai";
            this.Selesai.UseVisualStyleBackColor = true;
            this.Selesai.Click += new System.EventHandler(this.Selesai_Click);
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.Location = new System.Drawing.Point(370, 148);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(200, 22);
            this.TanggalLahir.TabIndex = 8;
            this.TanggalLahir.ValueChanged += new System.EventHandler(this.TanggalLahir_ValueChanged);
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(370, 80);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(200, 22);
            this.Nama.TabIndex = 9;
            this.Nama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.FormattingEnabled = true;
            this.JenisKelamin.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.JenisKelamin.Location = new System.Drawing.Point(370, 111);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(200, 24);
            this.JenisKelamin.TabIndex = 10;
            this.JenisKelamin.SelectedIndexChanged += new System.EventHandler(this.JenisKelamin_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 478);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.Selesai);
            this.Controls.Add(this.Tampilkan);
            this.Controls.Add(this.PilihanJadwal);
            this.Controls.Add(this.PilihanKelas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PilihanKelas.ResumeLayout(false);
            this.PilihanKelas.PerformLayout();
            this.PilihanJadwal.ResumeLayout(false);
            this.PilihanJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox PilihanKelas;
        private System.Windows.Forms.CheckBox Panahan;
        private System.Windows.Forms.CheckBox Voli;
        private System.Windows.Forms.CheckBox BuluTangkis;
        private System.Windows.Forms.CheckBox Basket;
        private System.Windows.Forms.CheckBox Yoga;
        private System.Windows.Forms.CheckBox Tenis;
        private System.Windows.Forms.CheckBox Renang;
        private System.Windows.Forms.CheckBox SepakBola;
        private System.Windows.Forms.GroupBox PilihanJadwal;
        private System.Windows.Forms.RadioButton Senin;
        private System.Windows.Forms.RadioButton Minggu;
        private System.Windows.Forms.RadioButton Sabtu;
        private System.Windows.Forms.RadioButton Selasa;
        private System.Windows.Forms.Button Tampilkan;
        private System.Windows.Forms.Button Selesai;
        private System.Windows.Forms.DateTimePicker TanggalLahir;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.ComboBox JenisKelamin;
    }
}

