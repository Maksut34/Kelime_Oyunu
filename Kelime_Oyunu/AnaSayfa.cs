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
            //this.FormClosing += new FormClosingEventHandler(Ana_Men�_FormClosing);

            bool closing = false;
            void Ana_Men�_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (!closing && e.CloseReason == CloseReason.UserClosing)
                {
                    closing = true;
                    DialogResult result = MessageBox.Show("Oyundan ��kmak istedi�inize emin misiniz?", "Program Kapat�l�yor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void btn_giri�_Click(object sender, EventArgs e)
        {

            IUsersDal usersDal = new UsersDal();
            IUsersService service = new UsersManager(usersDal);
            Giri� g = new Giri�(service);
            panel1.Controls.Clear();
            panel1.Controls.Add(g);
            g.Show();

        }

        private void btn_kay�t_Click(object sender, EventArgs e)
        {
            IUsersDal usersDal = new UsersDal();
            IUsersService service = new UsersManager(usersDal);
            Kay�t k = new Kay�t(service);
            panel1.Controls.Clear();
            panel1.Controls.Add(k);
            k.Show();
        }

        private void btn_���k��_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oyundan ��kmak istedi�inize emin misiniz?", "Program Kapat�l�yor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_�neriler_Click(object sender, EventArgs e)
        {
            I�neriDal �neridal = new �neriDal();
            I�neriService �neri = new �neriManager(�neridal);

            IUsersDal usersDal = new UsersDal();
            IUsersService service = new UsersManager(usersDal);
            �neriler � = new �neriler(�neri, service);
            panel1.Controls.Clear();
            panel1.Controls.Add(�);
            �.Show();

        }

        private void btnAnasayfa_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(panel2);
        }

       
    }
}