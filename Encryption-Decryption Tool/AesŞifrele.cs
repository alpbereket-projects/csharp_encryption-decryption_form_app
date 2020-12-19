using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
        //Şifreleme için gerekli importlar
using System.Security.Cryptography;
using System.IO;

namespace Encryption_Decryption
{
    public partial class AesŞifrele : Form
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int BlockSize = 128;
        public AesŞifrele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //Şifreleme
            byte[] bytes = Encoding.Unicode.GetBytes(txtAnahtarKelime.Text);
            
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.BlockSize = BlockSize;
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(txtYaziSifre.Text));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }

                txtYaziSifre.Text = Convert.ToBase64String(memoryStream.ToArray());
            }
        }

        private void txtAnahtarKelime_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Secenekler_Formu formGeriDon22 = new Secenekler_Formu();
            this.Visible = false;
            formGeriDon22.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AesCoz formAesCoz = new AesCoz();
            this.Visible = false;
            formAesCoz.Show();
        }

        private void programdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAnahtarKelime.Clear();
            txtYaziSifre.Clear();
        }
    }
    }

