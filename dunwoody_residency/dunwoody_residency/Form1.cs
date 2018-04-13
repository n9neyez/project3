using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dunwoody_residency
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        // allows the window form to be movable without the title bar, must click top of window
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        private void form_login_Load(object sender, EventArgs e)
        {

        }
        // exits program when EXIT button is clicked
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // login with generic username and password -- Username: user1      Password: password1
        private void btn_login_Click(object sender, EventArgs e)
        {
            // generic username and password to login
            string USERNAME = "user1", PASSWORD = "password1";
            // variables to hold what user will type into the text boxes respectively
            string usernameIn = textBox_username.Text;
            string passwordIn = textBox_password.Text;
            
            if (usernameIn == USERNAME && passwordIn == PASSWORD)
            {
                this.Hide();
                form_resident residentForm = new form_resident();
                residentForm.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and password...\n Username: user1\tPassword: password1");
            }
        }


    }
}
