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
    public partial class CAESAR : Form
    {
        public CAESAR()
        {
            InitializeComponent();
        }

    //    public Encoding sifre { get; private set; }

        private void enb_Click(object sender, EventArgs e)
        {
            string enter = intxt.Text;
            int key = Convert.ToInt32(inkey.Text);
            char[] small = { 'a', 'b', 'c', 'ç', 'd', 'e', 'ə', 'f', 'g', 'ğ', 'h', 'x', 'ı', 'i', 'j', 'k', 'q', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
            char[] big = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'Ə', 'F', 'G', 'Ğ', 'H', 'X', 'I', 'İ', 'J', 'K', 'Q', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
            char[] pmarks = { ' ', '.', '!', '?', '_', '-', ';', ':', ',', '/', '|', '@', '#', '$', '%', '^', '*', '(', ')', '+', '=', '[', ']', '{', '}', '<', '>', '~', '"', '`', ' ', '\\' };
            string sifrele = "";
           
            if(key>=32)
            {
                key %= 32;
            }

            for (int j = 0; j < enter.Length; j++)
            {
                for (int end = 0; end < big.Length; end++)
                {
                    if (enter[j] == pmarks[end])
                    {
                        int mod = end;
                        sifrele += pmarks[mod];
                        ende.Text = sifrele;
                        if (enter[j] == ' ')
                        {
                            break;
                        }
                    }

                    if (enter[j] == big[end])
                    {
                        int count = end + key;

                        if (count >= big.Length)
                        {
                            int mod = count - big.Length;
                            sifrele += big[mod];
                            ende.Text = sifrele;
                        }
                        else sifrele += big[end + key];
                        ende.Text = sifrele;
                    }
                    else if (enter[j] == small[end])
                    {
                        int count = end + key;

                        if (count >= small.Length)
                        {
                            int mod = count - small.Length;
                            sifrele += small[mod];
                            ende.Text = sifrele;
                        }
                        else sifrele += small[end + key];
                        ende.Text = sifrele;
                    }

                }

            }
        }

        private void deb_Click(object sender, EventArgs e)
        {
            string enterd = intxt.Text;
            int key = Convert.ToInt32(inkey.Text);
            char[] smalld = { 'a', 'b', 'c', 'ç', 'd', 'e', 'ə', 'f', 'g', 'ğ', 'h', 'x', 'ı', 'i', 'j', 'k', 'q', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
            char[] bigd = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'Ə', 'F', 'G', 'Ğ', 'H', 'X', 'I', 'İ', 'J', 'K', 'Q', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
            char[] pmarksd = { ' ', '.', '!', '?', '_', '-', ';', ':', ',', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            string sifrele2 = "";

            if (key >= 32)
            {
                key %= 32;
            }

            for (int j = 0; j < enterd.Length; j++)
            {
                for (int endd = 0; endd < bigd.Length; endd++)
                    if (enterd[j] == pmarksd[endd])
                    {
                        int mod = endd;
                        sifrele2 += pmarksd[mod];
                        ende.Text = enterd;
                        if (enterd[j] == ' ')
                        {
                            break;
                        }
                    }
                    else if (enterd[j] == bigd[endd])
                    {
                        int count = endd - key;

                        if (count < 0)
                        {
                            int mod = count + bigd.Length;
                            sifrele2 += bigd[mod];
                            ende.Text = sifrele2;
                        }
                        else sifrele2 += bigd[endd - key];
                        ende.Text = sifrele2;
                    }

                    else if (enterd[j] == smalld[endd])
                    {
                        int count = endd - key;

                        if (count < 0)
                        {
                            int mod = count + smalld.Length;
                            sifrele2 += smalld[mod];
                            ende.Text = sifrele2;
                        }
                        else sifrele2 += smalld[endd - key];
                        ende.Text = sifrele2;
                    }
            }
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
            ende.Clear();
            inkey.Clear();
            intxt.Clear();
        }
    }
    }
    
