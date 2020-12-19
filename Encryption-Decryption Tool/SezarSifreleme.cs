using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_Decryption
{
    public partial class SezarSifreleme : Form
    {
        // Program açıldığında ilk burası çalışıyor
        public SezarSifreleme()
        {
            InitializeComponent();

            txtAnahtarSayi.Select();
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            // Eğer textbox'lar boş değilse program başlıyor
            if (txtAnahtarSayi.Text != "" && txtYaziSifre.Text != "")
            {
                // Anahtar sayı olarak byte girilmediğinde 
                try
                {
                    // Yazdığım sınıftan bir nesne oluşturuyorum. Eğer anahtar sayı byte'a çevrilirken hata verirse program catch'e atlıyor
                    SezarSifrele sezar = new SezarSifrele(byte.Parse(txtAnahtarSayi.Text), txtYaziSifre.Text);

                   
                    txtSifrelenenYazi.Text = sezar.Sifrele();
                }

                
                catch
                {
                    MessageBox.Show("Lütfen anahtar sayıya 0 ile 255 arasında bir değer giriniz.");
                }
            }

            
            else
            {
                MessageBox.Show("Lütfen kutuları boş bırakmayınız.");
            }
        }

        
        private void buton2_Click(object sender, EventArgs e)
        {
            txtAnahtarSayi.Clear();
            txtYaziSifre.Clear();
            txtSifrelenenYazi.Clear();
        }

        // başka form gönderme
        private void şifreÇözToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SezarSifreCozucu form2 = new SezarSifreCozucu();
            this.Visible = false;
            form2.Show();
        }

        
        private void programdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Secenekler_Formu formGeriDon144 = new Secenekler_Formu();
            this.Visible = false;
            formGeriDon144.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}