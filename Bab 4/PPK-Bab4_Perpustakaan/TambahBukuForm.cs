using PPK_Bab4_Perpustakaan.Presenter;
using System;
using System.Windows.Forms;

namespace PPK_Bab4_Perpustakaan
{
    public partial class TambahBukuForm : Form
    {
        private MasterBukuPresenter _presenter;

        private static string msg = "Buku Berhasil Ditambahkan";

        public TambahBukuForm(MasterBukuPresenter presenter)
        {
            InitializeComponent();

            _presenter = presenter;
        }

        private void TambahBukuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTambahBuku_Click(object sender, EventArgs e)
        {
            string judul = textBoxJudulBuku.Text.ToString();
            string penerbit = textBoxPenerbitBuku.Text.ToString();
            string author = textBoxAuthorBuku.Text.ToString();

            try
            {
                int q = _presenter.TambahBuku(judul, penerbit, author);
                if (q > 0)
                {
                    MessageBox.Show(msg);
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
