using System.Windows.Forms;

namespace Lab6_WinForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtTu1, txtMau1, txtTu2, txtMau2;
        private Button btnTinh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTu1 = new TextBox();
            this.txtMau1 = new TextBox();
            this.txtTu2 = new TextBox();
            this.txtMau2 = new TextBox();
            this.btnTinh = new Button();

            Label lbl1 = new Label() { Text = "Phân số 1:", Location = new System.Drawing.Point(30, 20) };
            Label lblTu1 = new Label() { Text = "Tử số:", Location = new System.Drawing.Point(30, 50) };
            Label lblMau1 = new Label() { Text = "Mẫu số:", Location = new System.Drawing.Point(30, 80) };
            Label lbl2 = new Label() { Text = "Phân số 2:", Location = new System.Drawing.Point(30, 120) };
            Label lblTu2 = new Label() { Text = "Tử số:", Location = new System.Drawing.Point(30, 150) };
            Label lblMau2 = new Label() { Text = "Mẫu số:", Location = new System.Drawing.Point(30, 180) };

            this.txtTu1.Location = new System.Drawing.Point(100, 47);
            this.txtMau1.Location = new System.Drawing.Point(100, 77);
            this.txtTu2.Location = new System.Drawing.Point(100, 147);
            this.txtMau2.Location = new System.Drawing.Point(100, 177);
            this.btnTinh.Location = new System.Drawing.Point(100, 220);
            this.btnTinh.Text = "Tính & Hiển thị";
            this.btnTinh.Click += btnTinh_Click;

            this.Controls.AddRange(new Control[] { lbl1, lblTu1, txtTu1, lblMau1, txtMau1,
                                                   lbl2, lblTu2, txtTu2, lblMau2, txtMau2, btnTinh });
            this.Text = "Bài 1 - Nhập phân số";
            this.Size = new System.Drawing.Size(300, 300);
        }
    }
}