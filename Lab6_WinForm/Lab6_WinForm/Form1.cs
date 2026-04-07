using System;
using System.Windows.Forms;

namespace Lab6_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Gọi từ Designer.cs
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int tu1 = int.Parse(txtTu1.Text);
                int mau1 = int.Parse(txtMau1.Text);
                int tu2 = int.Parse(txtTu2.Text);
                int mau2 = int.Parse(txtMau2.Text);

                PhanSo ps1 = new PhanSo(tu1, mau1);
                PhanSo ps2 = new PhanSo(tu2, mau2);

                PhanSo tong = ps1.Cong(ps2);
                PhanSo hieu = ps1.Tru(ps2);
                PhanSo tich = ps1.Nhan(ps2);
                PhanSo thuong = ps1.Chia(ps2);

                Form2 form2 = new Form2(tong, hieu, tich, thuong);
                form2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Nhập liệu không hợp lệ");
            }
        }
    }
}