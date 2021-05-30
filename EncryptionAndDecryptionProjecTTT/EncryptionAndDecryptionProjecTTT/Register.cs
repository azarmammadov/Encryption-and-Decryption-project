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
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\belee.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void SingUpR_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backSL_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (shR1.Checked)
            {
                pswR1.UseSystemPasswordChar = true;
                pswR2.UseSystemPasswordChar = true;
            }
            else
            {
                pswR1.UseSystemPasswordChar = false;
                pswR2.UseSystemPasswordChar = false;
            }
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void registerb_Click(object sender, EventArgs e)
        {

            if (nameR.Text == "" && pswR1.Text == "" && pswR2.Text == "")

            {
                MessageBox.Show("Fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (pswR1.Text == pswR2.Text)
            {
                con.Open();
                string register = "INSERT INTO data1 VALUES ('" + nameR.Text + "','" + snameR.Text + "','" + UsernameR.Text + "','" + pswR1.Text + "','" + emailR.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                nameR.Text = "";
                snameR.Text = "";
                UsernameR.Text = "";
                pswR1.Text = "";
                emailR.Text = "";

                MessageBox.Show("Account Created", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pswR1.Text = "";
                pswR2.Text = "";
                pswR1.Focus();
            }

        }

        private void pswR2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}   
    
