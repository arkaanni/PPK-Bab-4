using PPK_Bab4_Perpustakaan.Views;

namespace PPK_Bab4_Perpustakaan.Presenter
{
    public class LoginPresenter
    {
        ILoginView _loginView;

        public LoginPresenter(ILoginView loginView)
        {
            _loginView = loginView;
        }

        public bool Login()
        {
            return _loginView.Username == "arkaan" && _loginView.Password == "arkaan";
        }
    }
}
