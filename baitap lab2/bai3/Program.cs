using System;

class Bai3
{
    static void Main()
    {
        int n;
        Console.Write("Nhap so n: ");
        n = int.Parse(Console.ReadLine());

        bool laSoNguyenTo = true;

        if (n < 2)
            laSoNguyenTo = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    laSoNguyenTo = false;
                    break;
                }
            }
        }

        if (laSoNguyenTo)
            Console.WriteLine("La so nguyen to");
        else
            Console.WriteLine("Khong phai so nguyen to");

        Console.ReadLine();
    }
}