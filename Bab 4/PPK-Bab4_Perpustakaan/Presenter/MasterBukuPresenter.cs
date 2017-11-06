using PPK_Bab4_Perpustakaan.Views;
using MySql.Data.MySqlClient;
using System.Data;

namespace PPK_Bab4_Perpustakaan.Presenter
{
    public class MasterBukuPresenter
    {
        IMasterBuku _masterBukuView;
        public MasterBukuPresenter(IMasterBuku view)
        {
            _masterBukuView = view;
        }

        private MySqlConnection _koneksi = Koneksi.Conn();
        private MySqlCommand _q;
        private string queryString;

        public void LoadBuku()
        {
            _koneksi.Open();
            
            queryString = "SELECT judul, penerbit, author, status FROM buku";

            MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, _koneksi);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            _koneksi.Close();

            _masterBukuView.ListMasterBuku = dt;
        }

        #region CRUD Buku
        public int TambahBuku(string judul, string penerbit, string author)
        {
            _koneksi.Open();

            queryString = "INSERT INTO buku (judul, penerbit, author) " +
                "VALUES ('" + judul + "', '" + penerbit + "', '" + author + "')";

            _q = new MySqlCommand(queryString, _koneksi);

            int row = _q.ExecuteNonQuery();

            _koneksi.Close();

            return row;
        }

        public void LihatBuku()
        {

        }

        public void EditBuku()
        {

        }

        public void HapusBuku()
        {

        }
        #endregion
    }
}
