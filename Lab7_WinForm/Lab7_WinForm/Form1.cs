using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab7_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HienThiListView();
            DataSharer.DanhSachSinhVien.ListChanged += (s, e) => HienThiListView();
        }

        private void HienThiListView()
        {
            listViewSinhVien.Items.Clear();
            foreach (var sv in DataSharer.DanhSachSinhVien)
            {
                ListViewItem item = new ListViewItem(sv.MaSV);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToShortDateString());
                item.Tag = sv;
                listViewSinhVien.Items.Add(item);
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDuongDanAnh.Text = dlg.FileName;
                pictureBoxAnh.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            DateTime ns = dtpNgaySinh.Value;
            string dc = txtDiaChi.Text.Trim();
            string anh = txtDuongDanAnh.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Mã SV và Họ tên không được để trống!");
                return;
            }

            SinhVien sv = new SinhVien(ma, ten, ns, dc, anh);
            DataSharer.DanhSachSinhVien.Add(sv);

            if (File.Exists(anh))
                pictureBoxAnh.Image = Image.FromFile(anh);
            else
                pictureBoxAnh.Image = null;

            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtDuongDanAnh.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void listViewSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSinhVien.SelectedItems.Count > 0)
            {
                SinhVien sv = listViewSinhVien.SelectedItems[0].Tag as SinhVien;
                if (sv != null && File.Exists(sv.DuongDanAnh))
                    pictureBoxAnh.Image = Image.FromFile(sv.DuongDanAnh);
                else
                    pictureBoxAnh.Image = null;
            }
        }
    }
}