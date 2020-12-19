﻿using System;
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
    public partial class SezarSifreCozucu : Form
    {
        // Program açıldığında ilk burası çalışıyor
        public SezarSifreCozucu()
        {
            InitializeComponent();

            // Program açıldığında hızlıca yazmaya başlamak için en üstteki textbox'ı seçiyorum
            txtAnahtarSayi.Select();
        }

        // "Onayla" butonuna basılınca program çalışıyor
        private void buton1_Click(object sender, EventArgs e)
        {
            // Eğer textbox'lar boş değilse program başlıyor
            if (txtAnahtarSayi.Text != "" && txtYaziSifre.Text != "")
            {
                // Anahtar sayı olarak byte girilmediğinde program hata vereceği için, programın geri kalanını try içine yazdım
                try
                {
                    // Yazdığım sınıftan bir nesne oluşturuyorum. Eğer anahtar sayı byte'a çevrilirken hata verirse program catch'e atlıyor
                    SezarSifrele sezar = new SezarSifrele(byte.Parse(txtAnahtarSayi.Text), txtYaziSifre.Text);

                    // Nesnenin "DesifreEt" metodunu kullanarak yazıyı deşifre ediyorum ve textbox'a yazdırıyorum.
                    txtDesifreEdilenYazi.Text = sezar.SifreCoz();
                }

                // Eğer girilen değer byte değilse ekrana uyarı mesajı yazdırıyorum
                catch
                {
                    MessageBox.Show("Lütfen anahtar sayıya 0 ile 255 arasında bir değer giriniz.");
                }
            }

            // Eğer kutular boşsa ekrana uyarı mesajı yazdırıyorum
            else
            {
                MessageBox.Show("Lütfen kutuları boş bırakmayınız.");
            }
        }

        // "Temizle" butonuna basılınca tüm textboxların içini temizliyorum
        private void buton2_Click(object sender, EventArgs e)
        {
            txtAnahtarSayi.Clear();
            txtYaziSifre.Clear();
            txtDesifreEdilenYazi.Clear();
        }

        // Menüde "Şifrele"ye tıklanırsa, bu formu gizleyip 1. formu (Şifrele) gösteriyorum
        private void şifreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SezarSifreleme form1 = new SezarSifreleme();
            this.Visible = false;
            form1.Show();
        }

        // "Programdan Çık" yazısına tıklanınca program kapanıyor
        private void programdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Secenekler_Formu formGeriDon1445 = new Secenekler_Formu();
            this.Visible = false;
            formGeriDon1445.Show();
        }
    }
}