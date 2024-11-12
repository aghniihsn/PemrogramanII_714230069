using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714230069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                setErrorMessages(textBox1, "Text Huruf Tidak Boleh Kosong!", "", "");
            }
            else if (textBox1.Text.All(Char.IsLetter))
            {
                setErrorMessages(textBox1, "", "", "Betul!");
            }
            else
            {
                setErrorMessages(textBox1, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                setErrorMessages(textBox2, "Textbox Angka tidak boleh kosong!", "", "");
            }
            else if (textBox2.Text.All(Char.IsNumber))
            {
                setErrorMessages(textBox2, "", "", "betul!");
            }
            else
            {
                setErrorMessages(textBox2, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                setErrorMessages(textBox3, "Textbox Email tidak ada yang kosong!", "", "");
            }
            else if (Regex.IsMatch(textBox3.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                setErrorMessages(textBox3, "", "", "Betul!");
            }
            else
            {
                setErrorMessages(textBox3, "", "Format email salah!\nContoh: a@b.c", "");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                setErrorMessages(textBox4, "Textbox Angka tidak boleh kosong!", "", "");
            }
            else if (textBox4.Text.All(Char.IsNumber))
            {
                setErrorMessages(textBox4, "", "", "betul!");
            }
            else
            {
                setErrorMessages(textBox4, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                setErrorMessages(textBox5, "Textbox Angka tidak boleh kosong!", "", "");
            }
            else if (textBox5.Text.All(Char.IsNumber))
            {
                setErrorMessages(textBox5, "", "", "betul!");
            }
            else
            {
                setErrorMessages(textBox5, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                setErrorMessages(textBox4, "Text Angka 1 Tidak Boleh Kosong!", "", "");
            }
            else if (textBox4.Text.All(Char.IsNumber))
            {
                setErrorMessages(textBox4, "", "", "Betul!");
            }
            else
            {
                setErrorMessages(textBox4, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                setErrorMessages(textBox5, "Kedua textbox Angka harus diisi!", "", "");
                return;
            }

            if (int.TryParse(textBox4.Text, out int angka1) && int.TryParse(textBox5.Text, out int angka2))
            {
                if (angka1 > angka2)
                {
                    setErrorMessages(textBox4, "", "", "Betul!");
                    setErrorMessages(textBox5, "", "", "Betul!");
                }
                else
                {
                    setErrorMessages(textBox4, "", "Angka 1 harus lebih besar dari Angka 2!", "");
                    setErrorMessages(textBox5, "", "Angka 1 harus lebih besar dari Angka 2!", "");
                }
            }
            else
            {
                setErrorMessages(textBox5, "", "Inputan harus berupa angka!", "");
            }

        }
    }
}
