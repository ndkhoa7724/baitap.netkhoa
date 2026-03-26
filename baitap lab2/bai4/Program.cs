using System;

class Bai4
{
    static void Main()
    {
        double a, b, c;
        Console.Write("Nhap a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Nhap c: ");
        c = double.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("La tam giac");

            if (a == b && b == c)
                Console.WriteLine("Tam giac deu");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Tam giac can");
            else if (a * a + b * b == c * c ||
                     a * a + c * c == b * b ||
                     b * b + c * c == a * a)
                Console.WriteLine("Tam giac vuong");
            else
                Console.WriteLine("Tam giac thuong");
        }
        else
        {
            Console.WriteLine("Khong phai tam giac");
        }

        Console.ReadLine();
    }
}