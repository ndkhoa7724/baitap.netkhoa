namespace Lab7_WinForm
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBai1 = new System.Windows.Forms.Button();
            this.btnBai2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // btnBai1
            this.btnBai1.Location = new System.Drawing.Point(50, 50);
            this.btnBai1.Name = "btnBai1";
            this.btnBai1.Size = new System.Drawing.Size(150, 40);
            this.btnBai1.TabIndex = 0;
            this.btnBai1.Text = "Bài tập 1 - ListView";
            this.btnBai1.UseVisualStyleBackColor = true;
            this.btnBai1.Click += new System.EventHandler(this.btnBai1_Click);
            // btnBai2
            this.btnBai2.Location = new System.Drawing.Point(50, 110);
            this.btnBai2.Name = "btnBai2";
            this.btnBai2.Size = new System.Drawing.Size(150, 40);
            this.btnBai2.TabIndex = 1;
            this.btnBai2.Text = "Bài tập 2 - DataGridView";
            this.btnBai2.UseVisualStyleBackColor = true;
            this.btnBai2.Click += new System.EventHandler(this.btnBai2_Click);
            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 200);
            this.Controls.Add(this.btnBai2);
            this.Controls.Add(this.btnBai1);
            this.Name = "FormMain";
            this.Text = "Lab 7 - Chọn bài tập";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBai1;
        private System.Windows.Forms.Button btnBai2;
    }
}