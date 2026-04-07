using System.Windows.Forms;

namespace Lab6_WinForm
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTong, lblHieu, lblTich, lblThuong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTong = new Label();
            this.lblHieu = new Label();
            this.lblTich = new Label();
            this.lblThuong = new Label();
            this.SuspendLayout();

            lblTong.Location = new System.Drawing.Point(30, 30);
            lblTong.AutoSize = true;
            lblHieu.Location = new System.Drawing.Point(30, 60);
            lblTich.Location = new System.Drawing.Point(30, 90);
            lblThuong.Location = new System.Drawing.Point(30, 120);

            this.Controls.AddRange(new Control[] { lblTong, lblHieu, lblTich, lblThuong });
            this.Text = "Kết quả phân số";
            this.Size = new System.Drawing.Size(300, 200);
            this.ResumeLayout(false);
        }
    }
}