using PPK_Bab4_Perpustakaan.Presenter;
using PPK_Bab4_Perpustakaan.Views;
using System;
using System.Windows.Forms;

namespace PPK_Bab4_Perpustakaan
{
    public partial class LoginForm : Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string Username { get => tbUsername.Text; set => Username = value; }
        public string Password { get => tbPassword.Text; set => Password = value; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPresenter loginPresenter = new LoginPresenter(this);
            if (loginPresenter.Login())
            {
                Perpus perpus = new Perpus();
                this.Hide();
                perpus.ShowDialog();
                this.Close();
            }
        }
    }
}
