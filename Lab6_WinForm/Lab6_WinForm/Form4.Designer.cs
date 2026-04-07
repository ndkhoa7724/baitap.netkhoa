using System.Drawing;
using System.Windows.Forms;

namespace Lab6_WinForm
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblInfo = new Label();
            this.SuspendLayout();
            lblInfo.Location = new Point(20, 20);
            lblInfo.AutoSize = true;
            this.Controls.Add(lblInfo);
            this.Text = "Thông tin hàng hóa";
            this.Size = new Size(300, 200);
            this.ResumeLayout(false);
        }
    }
}