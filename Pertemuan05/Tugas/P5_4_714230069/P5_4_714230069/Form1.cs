using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714230069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void JenisKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TanggalLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PilihanKelas_Enter(object sender, EventArgs e)
        {

        }

        private void SepakBola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Renang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tenis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Yoga_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Basket_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BuluTangkis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Voli_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Panahan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PilihanJadwal_Enter(object sender, EventArgs e)
        {

        }

        private void Senin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Selasa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rabu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Minggu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tampilkan_Click(object sender, EventArgs e)
        {
            string nama = Nama.Text;
            string jenisKelamin = JenisKelamin.SelectedItem?.ToString() ?? "";
            DateTime tanggalLahir = TanggalLahir.Value;

            List<string> pilihanKelas = new List<string>();
            if (SepakBola.Checked) pilihanKelas.Add("Sepak Bola");
            if (Renang.Checked) pilihanKelas.Add("Renang");
            if (Tenis.Checked) pilihanKelas.Add("Tenis");
            if (Yoga.Checked) pilihanKelas.Add("Yoga");
            if (Basket.Checked) pilihanKelas.Add("Basket");
            if (BuluTangkis.Checked) pilihanKelas.Add("Bulu Tangkis");
            if (Voli.Checked) pilihanKelas.Add("Voli");
            if (Panahan.Checked) pilihanKelas.Add("Panahan");

            string pilihanJadwal = "";
            if (Senin.Checked) pilihanJadwal = "Senin s/d Rabu, 14.00 - 16.00";
            else if (Selasa.Checked) pilihanJadwal = "Selasa s/d Kamis, 14.00 - 16.00";
            else if (Sabtu.Checked) pilihanJadwal = "Sabtu s/d Minggu, 09.00 - 11.00";
            else if (Minggu.Checked) pilihanJadwal = "Minggu, 13.00 - 20.00";

            if (pilihanKelas.Count == 0)
            {
                MessageBox.Show("Harus memilih salah satu dari kelas", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(pilihanJadwal))
            {
                MessageBox.Show("Harus memilih salah satu jadwal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hasil = $"Nama: {nama}\nJenis Kelamin: {jenisKelamin}\nTanggal Lahir: {tanggalLahir.ToShortDateString()}\n" +
                           $"Pilihan Kelas: {string.Join(", ", pilihanKelas)}\nPilihan Jadwal: {pilihanJadwal}";

            MessageBox.Show(hasil, "Hasil Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Selesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
