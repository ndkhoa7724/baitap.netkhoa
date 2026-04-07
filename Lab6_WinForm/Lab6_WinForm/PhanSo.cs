using System;

namespace Lab6_WinForm
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo(int tu = 0, int mau = 1)
        {
            if (mau == 0) throw new DivideByZeroException("Mẫu số không thể bằng 0");
            TuSo = tu;
            MauSo = mau;
            RutGon();
        }

        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public void RutGon()
        {
            int ucln = UCLN(TuSo, MauSo);
            TuSo /= ucln;
            MauSo /= ucln;
            if (MauSo < 0) // Đưa mẫu số về dương
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }
        }

        public PhanSo Cong(PhanSo other)
        {
            int tu = TuSo * other.MauSo + other.TuSo * MauSo;
            int mau = MauSo * other.MauSo;
            return new PhanSo(tu, mau);
        }

        public PhanSo Tru(PhanSo other)
        {
            int tu = TuSo * other.MauSo - other.TuSo * MauSo;
            int mau = MauSo * other.MauSo;
            return new PhanSo(tu, mau);
        }

        public PhanSo Nhan(PhanSo other)
        {
            return new PhanSo(TuSo * other.TuSo, MauSo * other.MauSo);
        }

        public PhanSo Chia(PhanSo other)
        {
            if (other.TuSo == 0) throw new DivideByZeroException("Không thể chia cho phân số 0");
            return new PhanSo(TuSo * other.MauSo, MauSo * other.TuSo);
        }

        public override string ToString()
        {
            if (MauSo == 1) return TuSo.ToString();
            return $"{TuSo}/{MauSo}";
        }
    }
}