namespace Lab6_WinForm
{
    public class HangHoa
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public decimal ThanhTien => SoLuong * DonGia;

        public HangHoa(string maHang, string tenHang, int soLuong, decimal donGia)
        {
            MaHang = maHang;
            TenHang = tenHang;
            SoLuong = soLuong;
            DonGia = donGia;
        }
    }
}