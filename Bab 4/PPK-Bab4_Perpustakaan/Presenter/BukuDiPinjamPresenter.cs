using MySql.Data.MySqlClient;
using PPK_Bab4_Perpustakaan.Views;
using System.Data;

namespace PPK_Bab4_Perpustakaan.Presenter
{
    public class BukuDiPinjamPresenter
    {
        IBukuDiPinjam _bukuDiPinjamView;
        public BukuDiPinjamPresenter(IBukuDiPinjam bukuDiPinjam)
        {
            _bukuDiPinjamView = bukuDiPinjam;
        }

        private MySqlConnection _koneksi = Koneksi.Conn();
        private MySqlCommand _q;
        private string queryString;

        public void LoadBuku()
        {
            _koneksi.Open();

            queryString = 
                "SELECT b.id, b.judul, b.penerbit, b.author, p.nama " +
                "FROM buku as b, transaksi_buku as t, peminjam as p " +
                "WHERE b.id=t.buku_id AND t.peminjam_id=p.id AND b.status=1 AND t.status=0";

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, _koneksi);
            adapter.Fill(dt);

            _koneksi.Close();

            _bukuDiPinjamView.ListBukuDiPinjam = dt;
        }
    }
}
