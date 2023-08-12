
using BLL.Abstarct;
using BLL.Concreate;
using Kel_DAL.Abstract;
using Kel_DAL.Concreate;
using Kel_Entity.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kelime_Oyunu
{

    public partial class Kayıt : UserControl
    {
        private IUsersService _users;
        public Kayıt(IUsersService users)
        {
            _users = users;
            InitializeComponent();
        }

        private void Kayıt_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                txt_şifre.PasswordChar = '\0';
            }
            else
            {
                // Şifreyi gizle
                txt_şifre.PasswordChar = '*';
            }

            txt_şifre.Focus();
            txt_şifre.Select(txt_şifre.Text.Length, 0);


            //this.FormClosing += new FormClosingEventHandler(Ana_Menü_FormClosing);
        }
        //bool closing = false;
        //private void Ana_Menü_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //	if (!closing && e.CloseReason == CloseReason.UserClosing)
        //	{
        //		closing = true;
        //		DialogResult result = MessageBox.Show("Ana Menüye gitmek istediğinize emin misiniz?", "Program Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //		if (result == DialogResult.No)
        //		{
        //			e.Cancel = true;
        //			closing = false;
        //		}
        //		else
        //		{
        //			AnaSayfa a = new AnaSayfa();
        //			this.Close();
        //			a.Show();
        //		}
        //	}
        //}




        public void sıfırla()
        {
            txt_ad.Clear();
            txt_email.Clear();
            txt_soyad.Clear();
            txt_şifre.Clear();
            maskedtxt_gsm.Clear();

        }



        private void btn_giriş_Click(object sender, EventArgs e)
        {
            Giriş g = new Giriş(_users);
            panel_kayıt.Controls.Clear();
            panel_kayıt.Controls.Add(g);
            g.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_şifre.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            var use = _users.Find(i => txt_email.Text == i.email);
            if (use == null)
            {
                Users u = new Users();
                u.email = txt_email.Text;
                u.password = txt_şifre.Text;
                u.surname = txt_soyad.Text;
                u.name = txt_ad.Text;
                u.gsm = maskedtxt_gsm.Text;

                _users.Insert(u);

                sıfırla();

                MessageBox.Show("Kayıt işlemi gerçekleşti!");
            }
            else
            {
                MessageBox.Show("Email zaten mevcut!");
            }
        }
    }
}
