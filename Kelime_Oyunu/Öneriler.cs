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
    public partial class Öneriler : UserControl
    {
        private IÖneriService _öneri;
        private IUsersService _users;
        public Öneriler(IÖneriService öneri, IUsersService users)
        {
            _öneri = öneri;
            _users = users;
            InitializeComponent();
        }

        private void Öneriler_Load(object sender, EventArgs e)
        {

        }
        bool closing = false;


        private void btn_öneri_yolla_Click(object sender, EventArgs e)
        {
            if (txt_soru.Text == "" && txt_cevap.Text == "" && txt_email.Text == "")
            {
                MessageBox.Show("Bütün alanların doldurulması zorunludur!");
            }
            else
            {
                var User = _users.Find(i => txt_email.Text == i.email);

                if (User != null)
                {

                    Kel_Entity.Model.Öneriler ö = new Kel_Entity.Model.Öneriler();

                    ö.Soru = txt_soru.Text;
                    ö.cevap = txt_cevap.Text;

                    _öneri.Insert(ö);

                    sıfırla();

                    MessageBox.Show("Öneri gönderildi! Uygunsa kullanılacak! Teşekkürler..");

                }
                else
                {
                    MessageBox.Show("Email mevcut değil!");
                }
            }
        }

        public void sıfırla()
        {
            txt_soru.Text = "";
            txt_cevap.Text = "";
            txt_email.Text = "";
        }
    }
}
