using System.Windows.Forms;

namespace Lab6_WinForm
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtMa, txtTen, txtSoLuong, txtDonGia;
        private Button btnHienThi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMa = new TextBox();
            this.txtTen = new TextBox();
            this.txtSoLuong = new TextBox();
            this.txtDonGia = new TextBox();
            this.btnHienThi = new Button();

            Label lblMa = new Label() { Text = "Mã hàng:", Location = new System.Drawing.Point(30, 30) };
            Label lblTen = new Label() { Text = "Tên hàng:", Location = new System.Drawing.Point(30, 60) };
            Label lblSoLuong = new Label() { Text = "Số lượng:", Location = new System.Drawing.Point(30, 90) };
            Label lblDonGia = new Label() { Text = "Đơn giá:", Location = new System.Drawing.Point(30, 120) };

            this.txtMa.Location = new System.Drawing.Point(120, 27);
            this.txtTen.Location = new System.Drawing.Point(120, 57);
            this.txtSoLuong.Location = new System.Drawing.Point(120, 87);
            this.txtDonGia.Location = new System.Drawing.Point(120, 117);
            this.btnHienThi.Location = new System.Drawing.Point(120, 160);
            this.btnHienThi.Text = "Hiển thị trên Form4";
            this.btnHienThi.Click += btnHienThi_Click;

            this.Controls.AddRange(new Control[] { lblMa, txtMa, lblTen, txtTen,
                                                   lblSoLuong, txtSoLuong, lblDonGia, txtDonGia,
                                                   btnHienThi });
            this.Text = "Bài 2 - Nhập hàng hóa";
            this.Size = new System.Drawing.Size(350, 250);
        }
    }
}