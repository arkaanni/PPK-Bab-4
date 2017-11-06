
namespace PPK_Bab4_Perpustakaan.Views
{
    public interface IPinjamBuku
    {
        string Buku_id { get; set; }
        System.Data.DataTable ListPeminjam { get; set; }
        int Row { get; set; }
    }
}
