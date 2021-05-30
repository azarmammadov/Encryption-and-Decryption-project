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
using System.Net;
using System.IO;



namespace EncryptionAndDecryptionProjecTTT
{
    public partial class md5 : Form
    {
        public md5()
        {
            InitializeComponent();
        }
   
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void md5_Load(object sender, EventArgs e)
        {

        }

        private void md5T_Click(object sender, EventArgs e)
        {

        }

        private void enmd5_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void demd5b_Click(object sender, EventArgs e)
        {

        }
        public static string encryption(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder stbuild = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                stbuild.Append(result[i].ToString("x2"));
            }
            return stbuild.ToString();
        }

        private void enmd5b_Click(object sender, EventArgs e)
        {
            //_durum = "1";
            //bres cavab
            // btx daxil olunan

            enmd5.Text = encryption(inmd5.Text);

        }

        private void exitL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeL_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backSL_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Show();
            this.Hide();
        }

        private void clR_Click(object sender, EventArgs e)
        {
            enmd5.Clear();
            inmd5.Clear();
        }
    }
}
