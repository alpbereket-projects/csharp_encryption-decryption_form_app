using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Encryption_Decryption
{
    public partial class AesCoz : Form
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public AesCoz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Çözme 
            byte[] bytes = Convert.FromBase64String(txtAnahtarKelime.Text);
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(txtYaziSifre.Text));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[bytes.Length];
                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                    txtYaziSifre.Text = Encoding.Unicode.GetString(decryptedBytes);
                }
            }
       
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Secenekler_Formu formGeriDon222 = new Secenekler_Formu();
            this.Visible = false;
            formGeriDon222.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AesŞifrele formSifreleAES = new AesŞifrele();
            this.Visible = false;
            formSifreleAES.Show();
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
