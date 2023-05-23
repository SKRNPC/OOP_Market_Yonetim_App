using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_ProjeOdevi_Market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kullanici1_Click(object sender, EventArgs e)
        {
            kullanici1.Text = "";
        }

        private void sifre1_Click(object sender, EventArgs e)
        {
            sifre1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanici1.Text == "" || sifre1.Text == "")
            {
                MessageBox.Show("Kullanıcı adı/Şifre giriniz!!");
            }
            else
            {
                if (kullanici1.Text == "admin" && sifre1.Text == "admin" || kullanici1.Text == "user" && sifre1.Text == "user")
                {
                    Form2 frm1 = new Form2();
                    frm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!!");
                    kullanici1.Text = "";
                    sifre1.Text = "";
                }
            }
        }
    }
}
