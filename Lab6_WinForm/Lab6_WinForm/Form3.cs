using System;
using System.Windows.Forms;

namespace Lab6_WinForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text;
                string ten = txtTen.Text;
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal donGia = decimal.Parse(txtDonGia.Text);

                HangHoa hh = new HangHoa(ma, ten, soLuong, donGia);
                Form4 form4 = new Form4(hh);
                form4.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập liệu: " + ex.Message);
            }
        }
    }
}