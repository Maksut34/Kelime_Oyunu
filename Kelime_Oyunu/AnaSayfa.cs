using BLL.Abstarct;
using BLL.Concreate;
using Kel_DAL.Abstract;
using Kel_DAL.Concreate;
using System.Windows.Forms.Design;

namespace Kelime_Oyunu
{
    public partial class AnaSayfa : Form
    {


        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            //this.FormClosing += new FormClosingEventHandler(Ana_Menü_FormClosing);

            bool closing = false;
            void Ana_Menü_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (!closing && e.CloseReason == CloseReason.UserClosing)
                {
                    closing = true;
                    DialogResult result = MessageBox.Show("Oyundan çýkmak istediðinize emin misiniz?", "Program Kapatýlýyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                        closing = false;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }

        }

        private void btn_giriþ_Click(object sender, EventArgs e)
        {

            IUsersDal usersDal = new UsersDal();
            IUsersService service = new UsersManager(usersDal);
            Giriþ g = new Giriþ(service);
            panel1.Controls.Clear();
            panel1.Controls.Add(g);
            g.Show();

        }

        private void btn_kayýt_Click(object sender, EventArgs e)
        {
            IUsersDal usersDal = new UsersDal();
            IUsersService service = new UsersManager(usersDal);
            Kayýt k = new Kayýt(service);
            panel1.Controls.Clear();
            panel1.Controls.Add(k);
            k.Show();
        }

        private void btn_çýýkýþ_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oyundan çýkmak istediðinize emin misiniz?", "Program Kapatýlýyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_öneriler_Click(object sender, EventArgs e)
        {
            IÖneriDal öneridal = new ÖneriDal();
            IÖneriService öneri = new ÖneriManager(öneridal);

            IUsersDal usersDal = new UsersDal();
            IUsersService service = new UsersManager(usersDal);
            Öneriler ö = new Öneriler(öneri, service);
            panel1.Controls.Clear();
            panel1.Controls.Add(ö);
            ö.Show();

        }

        private void btnAnasayfa_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(panel2);
        }

       
    }
}