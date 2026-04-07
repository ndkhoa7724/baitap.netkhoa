using System.Windows.Forms;

namespace Lab6_WinForm
{
    public partial class Form2 : Form
    {
        public Form2(PhanSo tong, PhanSo hieu, PhanSo tich, PhanSo thuong)
        {
            InitializeComponent();
            lblTong.Text = $"Tổng: {tong}";
            lblHieu.Text = $"Hiệu: {hieu}";
            lblTich.Text = $"Tích: {tich}";
            lblThuong.Text = $"Thương: {thuong}";
        }
    }
}