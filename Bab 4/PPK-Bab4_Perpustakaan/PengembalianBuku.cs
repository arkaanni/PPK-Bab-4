using PPK_Bab4_Perpustakaan.Presenter;
using PPK_Bab4_Perpustakaan.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPK_Bab4_Perpustakaan
{
    public partial class PengembalianBuku : Form, IPinjamBuku
    {
        private PinjamPresenter _presenter;

        public PengembalianBuku()
        {
            InitializeComponent();

            _presenter = new PinjamPresenter(this);
        }

        private string _buku_id;
        public string Buku_id { get => _buku_id; set => _buku_id = value; }

        private DataTable _listPeminjam;
        public DataTable ListPeminjam { get => _listPeminjam; set => _listPeminjam = value; }

        private int _row;
        public int Row { get => _row; set => _row = value; }

        private void btnKembalikanBuku_Click(object sender, EventArgs e)
        {
            try
            {
                int q = _presenter.KembalikanBuku(textBoxIdBuku.Text.ToString());
                if (q > 0)
                {
                    MessageBox.Show("Berhasil");
                    this.Close();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
