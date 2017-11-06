using PPK_Bab4_Perpustakaan.Presenter;
using PPK_Bab4_Perpustakaan.Views;
using System;
using System.Data;
using System.Windows.Forms;

namespace PPK_Bab4_Perpustakaan
{
    public partial class Perpus : Form, IBukuDiPinjam
    {
        BukuDiPinjamPresenter _presenter;
        public Perpus()
        {
            InitializeComponent();

            _presenter = new BukuDiPinjamPresenter(this);
            
            IsiKolom();
            IsiData();
        }

        void IsiData()
        {
            _presenter.LoadBuku();

            for (int i = 0; i < ListBukuDiPinjam.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(ListBukuDiPinjam.Rows[i]["id"].ToString());
                item.SubItems.Add(ListBukuDiPinjam.Rows[i]["judul"].ToString());
                item.SubItems.Add(ListBukuDiPinjam.Rows[i]["penerbit"].ToString());
                item.SubItems.Add(ListBukuDiPinjam.Rows[i]["author"].ToString());
                item.SubItems.Add(ListBukuDiPinjam.Rows[i]["nama"].ToString());

                listViewBukuDiPinjam.Items.Add(item);
            }
        }

        void IsiKolom()
        {
            listViewBukuDiPinjam.Columns.Add("ID Buku", 75);
            listViewBukuDiPinjam.Columns.Add("Judul", 150);
            listViewBukuDiPinjam.Columns.Add("Penerbit", 100);
            listViewBukuDiPinjam.Columns.Add("Author", 150);
            listViewBukuDiPinjam.Columns.Add("Peminjam", 150);
        }

        private DataTable _listBuku;
        public DataTable ListBukuDiPinjam { get => _listBuku; set => _listBuku = value; }

        private void Perpus_Load(object sender, EventArgs e)
        {
            listViewBukuDiPinjam.View = View.Details;
            listViewBukuDiPinjam.GridLines = true;
            listViewBukuDiPinjam.FullRowSelect = true;
        }

        private void dataBukuDipinjamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterBukuForm master = new MasterBukuForm();
            master.ShowDialog();
        }

        private void formPinjamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PinjamBukuForm pinjam = new PinjamBukuForm();
            pinjam.Show();
            pinjam.FormClosed += Pinjam_FormClosed;
        }

        private void Pinjam_FormClosed(object sender, FormClosedEventArgs e)
        {
            listViewBukuDiPinjam.Items.Clear();

            IsiData();
        }

        private void dataPeminjamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeminjamForm peminjamForm = new PeminjamForm();
            peminjamForm.Show();
        }
    }
}