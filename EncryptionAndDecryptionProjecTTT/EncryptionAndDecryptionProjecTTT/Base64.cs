using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionAndDecryptionProjecTTT
{
    public partial class Base64 : Form
    {
        public Base64()
        {
            InitializeComponent();
        }

        private void encR_Click(object sender, EventArgs e)
        {
            string basetext = textBox1.Text;
            byte[] basechiper = ASCIIEncoding.ASCII.GetBytes(basetext);
            string result = Convert.ToBase64String(basechiper);
            textBox2.Text = result;
        }

        private void demd5b_Click(object sender, EventArgs e)
        {
            string basetext2 = textBox1.Text;
            byte[] basechiper2 = Convert.FromBase64String(basetext2);
            string result2 = ASCIIEncoding.ASCII.GetString(basechiper2);
            textBox2.Text = result2;
        }

        private void clR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void minimizeL_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitL_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void backSL_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Show();
            this.Hide();
        }
    }
}
