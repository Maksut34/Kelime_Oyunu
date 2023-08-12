using BLL.Abstarct;
using BLL.Concreate;
using Kel_DAL.Abstract;
using Kel_DAL.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Oyunu
{
    public partial class Giriş : UserControl
    {
        private IUsersService _users;



        public Giriş(IUsersService users)
        {
            _users = users;
            InitializeComponent();

        }

        private void Giriş_Load(object sender, EventArgs e)
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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_şifre.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void btn__Click(object sender, EventArgs e)
        {
            var use = _users.Find(i => txt_email.Text == i.email && txt_şifre.Text == i.password);
            if (use != null)
            {
                IÖneriDal öneriDal = new ÖneriDal();
                IÖneriService öneri = new ÖneriManager(öneriDal);
                //AnaSayfa a = new AnaSayfa();
                //a.Hide();

                IUsersDal usersDal =new UsersDal();
                IUsersService users=new UsersManager(usersDal);

                YeniOyun y = new YeniOyun(öneri, users);
                panel_giriş.Controls.Clear();
                panel_giriş.Controls.Add(y);
                y.Show();

            }
            else
            {
                MessageBox.Show("Hata!! Yanlış email veya şifre!");
            }
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            Kayıt k=new Kayıt(_users);
            panel_giriş.Controls.Clear();
            panel_giriş.Controls.Add(k);
            k.Show();
        }
    }
}
