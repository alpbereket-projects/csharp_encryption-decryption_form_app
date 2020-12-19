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

namespace Encryption_Decryption
{
    public partial class MD5Sifreleme : Form
    {
        public MD5Sifreleme()
        {
            InitializeComponent();
        }
        public static string MD5_Sifrele(string metin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] btr = Encoding.UTF8.GetBytes(metin);
            btr = md5.ComputeHash(btr);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());

            }
            return sb.ToString();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAnahtarKelime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYaziSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str = MD5_Sifrele(txtAnahtarKelime.Text);
            txtYaziSifre.Text = str;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAnahtarKelime.Clear();
            txtYaziSifre.Clear();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

        private void programdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Secenekler_Formu formGeriDon2232 = new Secenekler_Formu();
            this.Visible = false;
            formGeriDon2232.Show();
        }
    }
}
