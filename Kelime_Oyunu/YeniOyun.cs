using BLL.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Oyunu
{
    public partial class YeniOyun : UserControl
    {
        private int saniyeSayac = 0;
        private int dakikaSayç = 0;

        private IUsersService _usersService;
        private IÖneriService _öneri;
        public YeniOyun(IÖneriService öneri, IUsersService usersService)
        {
            _usersService = usersService;
            _öneri = öneri;
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniyeSayac++;
            lbl_saniye.Text = saniyeSayac.ToString();

            if (saniyeSayac == 60)
            {
                saniyeSayac = 0;
                lbl_saniye.Text = saniyeSayac.ToString();

                dakikaSayç++;
                lbl_dakika.Text = dakikaSayç.ToString();
            }

        }

        private void btn_başla_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            lbl_Ekran.Text = _öneri.GetRandomSoru().Soru;
            saniyeSayac = 0;
            lbl_saniye.Text = saniyeSayac.ToString();
            timer1.Enabled = true;
        }

        private void btn_cevap_Click(object sender, EventArgs e)
        {
            var doğrumu = _öneri.Find(i => i.cevap == txt_cevap.Text && i.Soru == lbl_Ekran.Text);
            if (lbl_dakika.Text == "2" || doğrumu != null)
            {
                //pictureBox1.ImageLocation = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fonedio.com%2Fhaber%2Fpek-mutlu-oldugunuz-durumlari-paylastiginiz-zaman-kullanabileceginiz-gifler-293907&psig=AOvVaw0WX_FnA6ojfUCchG8wCK5B&ust=1691159613961000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCMishtLawIADFQAAAAAdAAAAABAE";


                timer1.Enabled = false;
                lbl_Ekran.Text = "";
                lbl_dakika.Text = "00";
                lbl_saniye.Text = "00";
                txt_cevap.Text = "";

                MessageBox.Show("Tebrikler.. Bildiniz!");
            }
        }
    }
}
