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
    public partial class reverse : Form
    {
        public reverse()
        {
            InitializeComponent();
        }

        private void reverse_Load(object sender, EventArgs e)
        {

        }

        private void encR_Click(object sender, EventArgs e)
        {
            for (int i = textBox1.Text.Length - 1; i >= 0; i--)
            {
                textBox2.Text = textBox2.Text + textBox1.Text[i].ToString();
            }
        }

        private void clR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
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
    }
}
