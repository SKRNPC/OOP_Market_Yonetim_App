
namespace NYP_ProjeOdevi_Market
{
    partial class Form1
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
            this.bHatirla = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sifre1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kullanici1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bHatirla
            // 
            this.bHatirla.AutoSize = true;
            this.bHatirla.Checked = true;
            this.bHatirla.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bHatirla.Location = new System.Drawing.Point(136, 314);
            this.bHatirla.Name = "bHatirla";
            this.bHatirla.Size = new System.Drawing.Size(103, 21);
            this.bHatirla.TabIndex = 11;
            this.bHatirla.Text = "Beni Hatırla";
            this.bHatirla.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(136, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(136, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 1);
            this.panel2.TabIndex = 9;
            // 
            // sifre1
            // 
            this.sifre1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifre1.Location = new System.Drawing.Point(136, 171);
            this.sifre1.Name = "sifre1";
            this.sifre1.Size = new System.Drawing.Size(162, 15);
            this.sifre1.TabIndex = 8;
            this.sifre1.Text = "Şifre";
            this.sifre1.Click += new System.EventHandler(this.sifre1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(136, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 1);
            this.panel1.TabIndex = 7;
            // 
            // kullanici1
            // 
            this.kullanici1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullanici1.Location = new System.Drawing.Point(136, 81);
            this.kullanici1.Name = "kullanici1";
            this.kullanici1.Size = new System.Drawing.Size(162, 15);
            this.kullanici1.TabIndex = 6;
            this.kullanici1.Text = "Kullanıcı Adı";
            this.kullanici1.Click += new System.EventHandler(this.kullanici1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 425);
            this.Controls.Add(this.bHatirla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sifre1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kullanici1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox bHatirla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox sifre1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox kullanici1;
    }
}