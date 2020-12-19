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
    public partial class VigenereSifreCozucu : Form
    {
        // Program açıldığında ilk burası çalışıyor
        public VigenereSifreCozucu()
        {
            InitializeComponent();

            // Program açıldığında hızlıca yazmaya başlamak için en üstteki textbox'ı seçiyorum
            txtAnahtarKelime.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Eğer textbox'lar boş değilse program başlıyor
            if (txtAnahtarKelime.Text != "" && txtYaziSifre.Text != "")
            {
                // Yazdığım sınıftan bir nesne oluşturuyorum.
                VigenereSifrele vigenere = new VigenereSifrele(txtAnahtarKelime.Text, txtYaziSifre.Text);

                // Anahtar kelimenin sadece İngilizce karakterler içerip içermediğine bakıyorum. Sorun varsa uyarı mesajı yazdırıyorum
                if (vigenere.AlfabetikKontrol())
                {
                    // Nesnenin "Sifrele" metodunu kullanarak yazıyı şifreliyorum ve textbox'a yazdırıyorum.
                    txtDesifreEdilenYazi.Text = vigenere.CozmeUygula();
                }
                else
                {
                    MessageBox.Show("Lütfen anahtar kelimeye İngilizce karakter dışında birşey girmeyiniz.");
                }
            }

            // Eğer kutular boşsa ekrana uyarı mesajı yazdırıyorum
            else
            {
                MessageBox.Show("Lütfen kutuları boş bırakmayınız.");
            }
        }

        // "Temizle" butonuna basılınca tüm textboxların içini temizliyorum
        private void button2_Click(object sender, EventArgs e)
        {
            txtAnahtarKelime.Clear();
            txtYaziSifre.Clear();
            txtDesifreEdilenYazi.Clear();
        }

        // Menüde "Şifrele"ye tıklanırsa, bu formu gizleyip 1. formu (Şifrele) gösteriyorum
        private void şifreÇözToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VigenereSifreleme form1 = new VigenereSifreleme();
            this.Visible = false;
            form1.Show();
        }

        // "Programdan Çık" yazısına tıklanınca program kapanıyor
        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VigenereSifreCozucu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Secenekler_Formu formGeriDon1 = new Secenekler_Formu();
            this.Visible = false;
            formGeriDon1.Show();
        }
    }
}
