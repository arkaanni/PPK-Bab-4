using System;
using PPK_Bab4_Perpustakaan.Views;
using MySql.Data.MySqlClient;
using System.Data;

namespace PPK_Bab4_Perpustakaan.Presenter
{
    public class PinjamPresenter
    {
        IPinjamBuku _pinjamBukuView;
        public PinjamPresenter(IPinjamBuku view)
        {
            _pinjamBukuView = view;
        }

        private MySqlConnection _koneksi = Koneksi.Conn();
        private string queryString;
        private MySqlCommand _q;

        public void DaftarPeminjam()
        {
            _koneksi.Open();

            queryString = "SELECT * FROM peminjam";

            _q = new MySqlCommand(queryString, _koneksi);

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, _koneksi);
            adapter.Fill(dt);

            _koneksi.Close();

            _pinjamBukuView.ListPeminjam = dt;
            _pinjamBukuView.Row = dt.Rows.Count;
        }

        public int PinjamBuku(string buku_id, string peminjam_id)
        {
            int row = 0;
            int buku = int.Parse(buku_id);
            int peminjam = int.Parse(peminjam_id);
            string _waktu = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            _koneksi.Open();

            //query untuk merubah status buku menjadi 1 (dipinjam)
            queryString = "UPDATE buku SET status=1 WHERE id=" + buku;

            _q = new MySqlCommand(queryString, _koneksi);
            row = _q.ExecuteNonQuery();

            if (row > 0)
            {
                //query untuk membuat transaksi pinjam baru
                queryString = "INSERT INTO transaksi_buku (buku_id, peminjam_id, tanggal_pinjam)" +
                "VALUES ('" + buku + "', '" + peminjam + "', '" + _waktu + "')";

                _q = new MySqlCommand(queryString, _koneksi);
                row = _q.ExecuteNonQuery();
            }

            _koneksi.Close();

            return row;
        }

        public int KembalikanBuku(string buku_id)
        {
            int row = 0;
            int buku = int.Parse(buku_id);
            string waktu = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            _koneksi.Open();

            queryString = 
                "UPDATE transaksi_buku " +
                "SET tanggal_kembali='" + waktu + "', status='0' " +
                "WHERE buku_id='" + buku + "'";

            _q = new MySqlCommand(queryString, _koneksi);

            row = _q.ExecuteNonQuery();

            if (row > 0)
            {
                queryString = 
                    "UPDATE buku " +
                    "SET status='0' " +
                    "WHERE id='" + buku + "'";

                _q = new MySqlCommand(queryString, _koneksi);
                row = _q.ExecuteNonQuery();
            }

            _koneksi.Close();

            return row;
        }
    }
}
