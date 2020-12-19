using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_Decryption
{
    public partial class Secenekler_Formu : Form
    {
        public Secenekler_Formu()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            VigenereSifreleme formVigenere = new VigenereSifreleme();
            this.Visible = false;
            formVigenere.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MD5 Şifreleme işleminde sadece şifreleme yapılabilmektedir.Çözme işlemi yapılamamaktadır");
            MD5Sifreleme formMD5 = new MD5Sifreleme();
            this.Visible = false;
            formMD5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AesŞifrele formAES1 = new AesŞifrele();
            this.Visible = false;
            formAES1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SezarSifreleme formSezar1 = new SezarSifreleme();
            this.Visible = false;
            formSezar1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SHA 256bit Şifreleme işleminde sadece şifreleme yapılabilmektedir.Çözme işlemi yapılamamaktadır");
            Sha256Sifrele formSHA256 = new Sha256Sifrele();
            this.Visible = false;
            formSHA256.Show();
        }
    }
}
