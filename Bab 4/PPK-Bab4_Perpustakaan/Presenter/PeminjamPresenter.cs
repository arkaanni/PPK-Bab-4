using MySql.Data.MySqlClient;
using PPK_Bab4_Perpustakaan.Views;
using System.Data;

namespace PPK_Bab4_Perpustakaan.Presenter
{
    class PeminjamPresenter
    {
        private IPeminjam _peminjamView;

        public PeminjamPresenter(IPeminjam view)
        {
            _peminjamView = view;
        }

        private MySqlConnection _koneksi = Koneksi.Conn();
        private string queryString;
        private MySqlCommand _q;

        public void LoadPeminjam()
        {
            _koneksi.Open();

            queryString = "SELECT * FROM peminjam";

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, _koneksi);

            adapter.Fill(dt);

            _koneksi.Close();

            _peminjamView.ListPeminjam = dt;

            _peminjamView.Row = dt.Rows.Count;
        }

        public int TambahPeminjam(string nama)
        {
            _koneksi.Open();

            queryString = "INSERT INTO peminjam (nama) VALUES ('"+ nama + "')";

            _q = new MySqlCommand(queryString, _koneksi);

            int row = _q.ExecuteNonQuery();

            _koneksi.Close();

            return row;
        }
    }
}
