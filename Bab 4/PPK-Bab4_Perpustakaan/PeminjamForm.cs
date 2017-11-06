using PPK_Bab4_Perpustakaan.Views;
using PPK_Bab4_Perpustakaan.Presenter;
using System;
using System.Data;
using System.Windows.Forms;

namespace PPK_Bab4_Perpustakaan
{
    public partial class PeminjamForm : Form, IPeminjam
    {
        private PeminjamPresenter _presenter;
        public PeminjamForm()
        {
            InitializeComponent();

            _presenter = new PeminjamPresenter(this);

            IsiKolom();
            IsiData();
        }

        private DataTable _listPeminjam;
        public DataTable ListPeminjam { get => _listPeminjam; set => _listPeminjam = value; }

        private int _row;
        public int Row { get => _row; set => _row = value; }

        private void IsiData()
        {
            _presenter.LoadPeminjam();

            for (int i = 0; i < Row; i++)
            {
                ListViewItem item = new ListViewItem(ListPeminjam.Rows[i]["id"].ToString());
                item.SubItems.Add(ListPeminjam.Rows[i]["nama"].ToString());

                listViewPeminjam.Items.Add(item);
            }
        }

        private void IsiKolom()
        {
            listViewPeminjam.View = View.Details;
            listViewPeminjam.GridLines = true;
            listViewPeminjam.FullRowSelect = true;

            listViewPeminjam.Columns.Add("ID", 75);
            listViewPeminjam.Columns.Add("Nama", 250);
        }

        private void btnTambahPeminjam_Click(object sender, EventArgs e)
        {
            try
            {
                int q = _presenter.TambahPeminjam(textBoxNama.Text.ToString());
                
                if (q > 0)
                {
                    MessageBox.Show("Berhasil");
                    listViewPeminjam.Items.Clear();
                    IsiData();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
