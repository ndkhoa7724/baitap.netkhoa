using System;
using System.Windows.Forms;

namespace Lab7_WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dgvDanhSach.DataSource = DataSharer.DanhSachSinhVien;
            dgvDanhSach.AutoGenerateColumns = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            DateTime ns = dtpNgaySinh.Value;
            string dc = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Mã và tên không được để trống!");
                return;
            }

            SinhVien sv = new SinhVien(ma, ten, ns, dc, "");
            DataSharer.DanhSachSinhVien.Add(sv);

            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }
    }
}