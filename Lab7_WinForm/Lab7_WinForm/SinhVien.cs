using System;

namespace Lab7_WinForm
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DuongDanAnh { get; set; }

        public SinhVien() { }

        public SinhVien(string ma, string ten, DateTime ns, string dc, string anh)
        {
            MaSV = ma;
            HoTen = ten;
            NgaySinh = ns;
            DiaChi = dc;
            DuongDanAnh = anh;
        }
    }
}