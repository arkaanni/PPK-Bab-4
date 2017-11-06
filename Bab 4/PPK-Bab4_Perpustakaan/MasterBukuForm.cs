using PPK_Bab4_Perpustakaan.Presenter;
using PPK_Bab4_Perpustakaan.Views;
using System;
using System.Data;
using System.Windows.Forms;

namespace PPK_Bab4_Perpustakaan
{
    public partial class MasterBukuForm : Form, IMasterBuku
    {
        private static MasterBukuPresenter _presenter;
        public MasterBukuForm()
        {
            InitializeComponent();

            _presenter = new MasterBukuPresenter(this);
            _presenter.LoadBuku();
            IsiKolom();
            IsiData();
        }

        void IsiData()
        {   
            listViewMasterBuku.View = View.Details;
            listViewMasterBuku.FullRowSelect = true;
            listViewMasterBuku.GridLines = true;

            for (int i = 0; i < ListMasterBuku.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(ListMasterBuku.Rows[i]["judul"].ToString());
                item.SubItems.Add(ListMasterBuku.Rows[i]["penerbit"].ToString());
                item.SubItems.Add(ListMasterBuku.Rows[i]["author"].ToString());

                if (ListMasterBuku.Rows[i]["status"].ToString() == "0")
                {
                    item.SubItems.Add("Tersedia");
                }
                else
                {
                    item.SubItems.Add("Dipinjam");
                }

                listViewMasterBuku.Items.Add(item);
            }
            
        }

        void IsiKolom()
        {
            listViewMasterBuku.Columns.Add("Judul", 150);
            listViewMasterBuku.Columns.Add("Penerbit", 100);
            listViewMasterBuku.Columns.Add("Author", 150);
            listViewMasterBuku.Columns.Add("Status", 100);
        }

        private DataTable _listMasterBuku;
        public DataTable ListMasterBuku { get => _listMasterBuku; set => _listMasterBuku = value; }

        public static TambahBukuForm tambahBukuForm;
        private void tambahBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tambahBukuForm = new TambahBukuForm(_presenter);
            tambahBukuForm.Show();
            tambahBukuForm.FormClosed += TambahBukuForm_FormClosed;
        }

        private void TambahBukuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listViewMasterBuku.Items.Clear();
            _presenter.LoadBuku();
            IsiData();
        }
    }
}
