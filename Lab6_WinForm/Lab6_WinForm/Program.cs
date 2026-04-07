using System;
using System.Windows.Forms;

namespace Lab6_WinForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // Chạy bài 1 trước
            Application.Run(new Form3());  // Sau khi đóng Form1, chạy bài 2
        }
    }
}