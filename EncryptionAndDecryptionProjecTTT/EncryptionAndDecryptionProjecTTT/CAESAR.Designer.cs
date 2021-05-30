
namespace EncryptionAndDecryptionProjecTTT
{
    partial class CAESAR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAESAR));
            this.clR = new System.Windows.Forms.Button();
            this.backSL = new System.Windows.Forms.Button();
            this.minimizeL = new System.Windows.Forms.Button();
            this.exitL = new System.Windows.Forms.Button();
            this.enb = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ende = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.intxt = new System.Windows.Forms.TextBox();
            this.intxtmd = new System.Windows.Forms.Label();
            this.md5T = new System.Windows.Forms.Label();
            this.deb = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clR
            // 
            this.clR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clR.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.clR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clR.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clR.ForeColor = System.Drawing.Color.White;
            this.clR.Location = new System.Drawing.Point(490, 302);
            this.clR.Name = "clR";
            this.clR.Size = new System.Drawing.Size(107, 28);
            this.clR.TabIndex = 75;
            this.clR.Text = "CLEAR";
            this.clR.UseVisualStyleBackColor = false;
            this.clR.Click += new System.EventHandler(this.clR_Click);
            // 
            // backSL
            // 
            this.backSL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backSL.BackgroundImage")));
            this.backSL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backSL.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.backSL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backSL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backSL.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.backSL.Location = new System.Drawing.Point(117, 387);
            this.backSL.Name = "backSL";
            this.backSL.Size = new System.Drawing.Size(40, 27);
            this.backSL.TabIndex = 74;
            this.backSL.UseVisualStyleBackColor = true;
            this.backSL.Click += new System.EventHandler(this.backSL_Click);
            // 
            // minimizeL
            // 
            this.minimizeL.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.minimizeL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeL.BackgroundImage")));
            this.minimizeL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeL.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.minimizeL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeL.Location = new System.Drawing.Point(641, 37);
            this.minimizeL.Name = "minimizeL";
            this.minimizeL.Size = new System.Drawing.Size(20, 20);
            this.minimizeL.TabIndex = 73;
            this.minimizeL.UseVisualStyleBackColor = false;
            this.minimizeL.Click += new System.EventHandler(this.minimizeL_Click);
            // 
            // exitL
            // 
            this.exitL.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitL.BackgroundImage")));
            this.exitL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitL.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.exitL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitL.Location = new System.Drawing.Point(667, 37);
            this.exitL.Name = "exitL";
            this.exitL.Size = new System.Drawing.Size(20, 20);
            this.exitL.TabIndex = 72;
            this.exitL.UseVisualStyleBackColor = false;
            this.exitL.Click += new System.EventHandler(this.exitL_Click);
            // 
            // enb
            // 
            this.enb.BackColor = System.Drawing.Color.DarkGreen;
            this.enb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enb.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.enb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enb.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enb.ForeColor = System.Drawing.Color.White;
            this.enb.Location = new System.Drawing.Point(117, 302);
            this.enb.Name = "enb";
            this.enb.Size = new System.Drawing.Size(107, 28);
            this.enb.TabIndex = 71;
            this.enb.Text = "ENCRYPT";
            this.enb.UseVisualStyleBackColor = false;
            this.enb.Click += new System.EventHandler(this.enb_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(117, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 1);
            this.panel2.TabIndex = 70;
            // 
            // ende
            // 
            this.ende.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ende.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ende.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ende.ForeColor = System.Drawing.Color.White;
            this.ende.Location = new System.Drawing.Point(117, 231);
            this.ende.Multiline = true;
            this.ende.Name = "ende";
            this.ende.Size = new System.Drawing.Size(480, 21);
            this.ende.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Encrypt/Decrypt:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(117, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 1);
            this.panel1.TabIndex = 67;
            // 
            // intxt
            // 
            this.intxt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.intxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intxt.ForeColor = System.Drawing.Color.White;
            this.intxt.Location = new System.Drawing.Point(117, 126);
            this.intxt.Multiline = true;
            this.intxt.Name = "intxt";
            this.intxt.Size = new System.Drawing.Size(480, 21);
            this.intxt.TabIndex = 66;
            // 
            // intxtmd
            // 
            this.intxtmd.AutoSize = true;
            this.intxtmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intxtmd.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intxtmd.ForeColor = System.Drawing.Color.White;
            this.intxtmd.Location = new System.Drawing.Point(114, 105);
            this.intxtmd.Name = "intxtmd";
            this.intxtmd.Size = new System.Drawing.Size(88, 18);
            this.intxtmd.TabIndex = 65;
            this.intxtmd.Text = "Input Text:";
            // 
            // md5T
            // 
            this.md5T.AutoSize = true;
            this.md5T.BackColor = System.Drawing.Color.Transparent;
            this.md5T.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.md5T.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.md5T.ForeColor = System.Drawing.Color.DarkViolet;
            this.md5T.Location = new System.Drawing.Point(319, 37);
            this.md5T.Name = "md5T";
            this.md5T.Size = new System.Drawing.Size(129, 32);
            this.md5T.TabIndex = 64;
            this.md5T.Text = "CAESAR";
            // 
            // deb
            // 
            this.deb.BackColor = System.Drawing.Color.Goldenrod;
            this.deb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deb.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.deb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deb.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deb.ForeColor = System.Drawing.Color.White;
            this.deb.Location = new System.Drawing.Point(296, 302);
            this.deb.Name = "deb";
            this.deb.Size = new System.Drawing.Size(107, 28);
            this.deb.TabIndex = 76;
            this.deb.Text = "DECRYPT";
            this.deb.UseVisualStyleBackColor = false;
            this.deb.Click += new System.EventHandler(this.deb_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(117, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 1);
            this.panel3.TabIndex = 79;
            // 
            // inkey
            // 
            this.inkey.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.inkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inkey.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inkey.ForeColor = System.Drawing.Color.White;
            this.inkey.Location = new System.Drawing.Point(117, 179);
            this.inkey.Multiline = true;
            this.inkey.Name = "inkey";
            this.inkey.Size = new System.Drawing.Size(107, 21);
            this.inkey.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 77;
            this.label1.Text = "Key:";
            // 
            // CAESAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.inkey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deb);
            this.Controls.Add(this.clR);
            this.Controls.Add(this.backSL);
            this.Controls.Add(this.minimizeL);
            this.Controls.Add(this.exitL);
            this.Controls.Add(this.enb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ende);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.intxt);
            this.Controls.Add(this.intxtmd);
            this.Controls.Add(this.md5T);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CAESAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAESAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clR;
        private System.Windows.Forms.Button backSL;
        private System.Windows.Forms.Button minimizeL;
        private System.Windows.Forms.Button exitL;
        private System.Windows.Forms.Button enb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ende;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox intxt;
        private System.Windows.Forms.Label intxtmd;
        private System.Windows.Forms.Label md5T;
        private System.Windows.Forms.Button deb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox inkey;
        private System.Windows.Forms.Label label1;
    }
}