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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void md5b_Click(object sender, EventArgs e)
        {
            md5 md5 = new md5();
            md5.Show();
            this.Hide();
        }

        private void backSL_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void exitL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeL_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }

        private void base64b_Click(object sender, EventArgs e)
        {
            Base64 base64 = new Base64();
            base64.Show();
            this.Hide();
        }

        private void Reverseb_Click(object sender, EventArgs e)
        {
            reverse reverset = new reverse();
            reverset.Show();
            this.Hide();
        }

        private void Caesarb_Click(object sender, EventArgs e)
        {
            CAESAR caesar = new CAESAR();
            caesar.Show();
            this.Hide();
        }
    }
}
