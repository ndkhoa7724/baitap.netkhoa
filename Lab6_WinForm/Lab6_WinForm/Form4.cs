using System.Windows.Forms;

namespace Lab6_WinForm
{
    public partial class Form4 : Form
    {
        public Form4(HangHoa hh)
        {
            InitializeComponent();
            lblInfo.Text = $"Mã hàng: {hh.MaHang}\n" +
                           $"Tên hàng: {hh.TenHang}\n" +
                           $"Số lượng: {hh.SoLuong}\n" +
                           $"Đơn giá: {hh.DonGia:C}\n" +
                           $"Thành tiền: {hh.ThanhTien:C}";
        }
    }
}