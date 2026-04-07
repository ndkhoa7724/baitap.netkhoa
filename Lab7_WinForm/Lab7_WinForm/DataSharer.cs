using System.ComponentModel;

namespace Lab7_WinForm
{
    public static class DataSharer
    {
        public static BindingList<SinhVien> DanhSachSinhVien { get; set; }
            = new BindingList<SinhVien>();
    }
}