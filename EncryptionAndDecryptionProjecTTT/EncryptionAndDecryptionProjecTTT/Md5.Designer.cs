
namespace EncryptionAndDecryptionProjecTTT
{
    partial class md5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(md5));
            this.md5T = new System.Windows.Forms.Label();
            this.intxtmd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inmd5 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enmd5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enmd5b = new System.Windows.Forms.Button();
            this.minimizeL = new System.Windows.Forms.Button();
            this.exitL = new System.Windows.Forms.Button();
            this.backSL = new System.Windows.Forms.Button();
            this.clR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // md5T
            // 
            this.md5T.AutoSize = true;
            this.md5T.BackColor = System.Drawing.Color.Transparent;
            this.md5T.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.md5T.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.md5T.ForeColor = System.Drawing.Color.DarkViolet;
            this.md5T.Location = new System.Drawing.Point(251, 12);
            this.md5T.Name = "md5T";
            this.md5T.Size = new System.Drawing.Size(71, 32);
            this.md5T.TabIndex = 1;
            this.md5T.Text = "MD5";
            this.md5T.Click += new System.EventHandler(this.md5T_Click);
            // 
            // intxtmd
            // 
            this.intxtmd.AutoSize = true;
            this.intxtmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intxtmd.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intxtmd.ForeColor = System.Drawing.Color.White;
            this.intxtmd.Location = new System.Drawing.Point(46, 80);
            this.intxtmd.Name = "intxtmd";
            this.intxtmd.Size = new System.Drawing.Size(88, 18);
            this.intxtmd.TabIndex = 2;
            this.intxtmd.Text = "Input Text:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(49, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 1);
            this.panel1.TabIndex = 7;
            // 
            // inmd5
            // 
            this.inmd5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.inmd5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inmd5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inmd5.ForeColor = System.Drawing.Color.White;
            this.inmd5.Location = new System.Drawing.Point(49, 101);
            this.inmd5.Multiline = true;
            this.inmd5.Name = "inmd5";
            this.inmd5.Size = new System.Drawing.Size(480, 21);
            this.inmd5.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(49, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 1);
            this.panel2.TabIndex = 10;
            // 
            // enmd5
            // 
            this.enmd5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.enmd5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enmd5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enmd5.ForeColor = System.Drawing.Color.White;
            this.enmd5.Location = new System.Drawing.Point(49, 163);
            this.enmd5.Multiline = true;
            this.enmd5.Name = "enmd5";
            this.enmd5.Size = new System.Drawing.Size(480, 21);
            this.enmd5.TabIndex = 9;
            this.enmd5.TextChanged += new System.EventHandler(this.enmd5_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Encrypt:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // enmd5b
            // 
            this.enmd5b.BackColor = System.Drawing.Color.DarkGreen;
            this.enmd5b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enmd5b.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.enmd5b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enmd5b.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enmd5b.ForeColor = System.Drawing.Color.White;
            this.enmd5b.Location = new System.Drawing.Point(49, 277);
            this.enmd5b.Name = "enmd5b";
            this.enmd5b.Size = new System.Drawing.Size(107, 28);
            this.enmd5b.TabIndex = 15;
            this.enmd5b.Text = "ENCRYPT";
            this.enmd5b.UseVisualStyleBackColor = false;
            this.enmd5b.Click += new System.EventHandler(this.enmd5b_Click);
            // 
            // minimizeL
            // 
            this.minimizeL.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.minimizeL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeL.BackgroundImage")));
            this.minimizeL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeL.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.minimizeL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeL.Location = new System.Drawing.Point(573, 12);
            this.minimizeL.Name = "minimizeL";
            this.minimizeL.Size = new System.Drawing.Size(20, 20);
            this.minimizeL.TabIndex = 17;
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
            this.exitL.Location = new System.Drawing.Point(599, 12);
            this.exitL.Name = "exitL";
            this.exitL.Size = new System.Drawing.Size(20, 20);
            this.exitL.TabIndex = 16;
            this.exitL.UseVisualStyleBackColor = false;
            this.exitL.Click += new System.EventHandler(this.exitL_Click);
            // 
            // backSL
            // 
            this.backSL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backSL.BackgroundImage")));
            this.backSL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backSL.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.backSL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backSL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backSL.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.backSL.Location = new System.Drawing.Point(49, 362);
            this.backSL.Name = "backSL";
            this.backSL.Size = new System.Drawing.Size(40, 27);
            this.backSL.TabIndex = 46;
            this.backSL.UseVisualStyleBackColor = true;
            this.backSL.Click += new System.EventHandler(this.backSL_Click);
            // 
            // clR
            // 
            this.clR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clR.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.clR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clR.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clR.ForeColor = System.Drawing.Color.White;
            this.clR.Location = new System.Drawing.Point(422, 277);
            this.clR.Name = "clR";
            this.clR.Size = new System.Drawing.Size(107, 28);
            this.clR.TabIndex = 63;
            this.clR.Text = "CLEAR";
            this.clR.UseVisualStyleBackColor = false;
            this.clR.Click += new System.EventHandler(this.clR_Click);
            // 
            // md5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(631, 413);
            this.Controls.Add(this.clR);
            this.Controls.Add(this.backSL);
            this.Controls.Add(this.minimizeL);
            this.Controls.Add(this.exitL);
            this.Controls.Add(this.enmd5b);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.enmd5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inmd5);
            this.Controls.Add(this.intxtmd);
            this.Controls.Add(this.md5T);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "md5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "md5";
            this.Load += new System.EventHandler(this.md5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label md5T;
        private System.Windows.Forms.Label intxtmd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inmd5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox enmd5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enmd5b;
        private System.Windows.Forms.Button minimizeL;
        private System.Windows.Forms.Button exitL;
        private System.Windows.Forms.Button backSL;
        private System.Windows.Forms.Button clR;
    }
}