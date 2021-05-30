using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EncryptionAndDecryptionProjecTTT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\belee.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameL_TextChanged(object sender, EventArgs e)
        {

        }
        private void UsernameL_Click(object sender, EventArgs e)
        {
    
        }
        
        private void pswL_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeL_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }

        private void showpswL_Click(object sender, EventArgs e)
        {

        }

        private void clpswL1_Click(object sender, EventArgs e)
        {
         
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void r1L_Click(object sender, EventArgs e)
        {

        }

        private void LoginLB_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM data1 WHERE username= '" + UsernameL.Text + "' and password= '" + pswL.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read()==true)
            {
                new Panel().Show();
                this.Hide();
            }

            else
            {

                MessageBox.Show("Enter your username and password correctly", "There was an error logging in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameL.Text = "";
                pswL.Text = "";
                UsernameL.Focus();

            }

        }

        private void singupL_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void pswL_Click(object sender, EventArgs e)
        {
            pswL.Clear();
        }
        private void pswL_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void shL_CheckedChanged(object sender, EventArgs e)
        {
            if (shL.Checked)
            {
                pswL.UseSystemPasswordChar = true;
            }
            else
            {
                pswL.UseSystemPasswordChar = false;
            }
        }

        private void remember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
