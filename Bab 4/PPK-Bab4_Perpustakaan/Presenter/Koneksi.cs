using MySql.Data.MySqlClient;

namespace PPK_Bab4_Perpustakaan.Presenter
{
    public static class Koneksi
    {
        private static string cred = "server=127.0.0.1;uid=root;pwd='';database=perpus";
        private static MySqlConnection _conn = new MySqlConnection(cred);

        public static MySqlConnection Conn()
        {
            return _conn;
        }
    }
}
