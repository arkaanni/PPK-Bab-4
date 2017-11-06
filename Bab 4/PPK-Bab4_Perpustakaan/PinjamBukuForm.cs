using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using PPK_Bab4_Perpustakaan.Views;
using PPK_Bab4_Perpustakaan.Presenter;

namespace PPK_Bab4_Perpustakaan
{
    public partial class PinjamBukuForm : Form, IPinjamBuku
    {
        private PinjamPresenter _presenter;
        public PinjamBukuForm()
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

        private void IsiDaftarPeminjam()
        {
            _presenter.DaftarPeminjam();

            for (int i = 0; i < Row; i++)
            {
                comboBoxListPeminjam.Items.Add(ListPeminjam.Rows[i]["nama"].ToString());
            }
        }

        private void btnSubmitPinjam_Click(object sender, EventArgs e)
        {
            try
            {
                string id = null;

                for (int i = 0; i < Row; i++)
                {
                    string nama = ListPeminjam.Rows[i]["nama"].ToString();
                    string selected = comboBoxListPeminjam.GetItemText(comboBoxListPeminjam.SelectedItem);

                    if (nama == selected)
                    {
                        id = ListPeminjam.Rows[i]["id"].ToString();
                    }
                }

                int q = _presenter.PinjamBuku(textBoxIdBuku.Text.ToString(), id);
                if (q > 0)
                {
                    MessageBox.Show("Berhasil");
                    this.Close();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void PinjamBukuForm_Load(object sender, EventArgs e)
        {
            IsiDaftarPeminjam();
        }
    }
}
