using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            CPhanSo a = new CPhanSo(5, 5);
            CPhanSo b = new CPhanSo(5, 2);

            CPhanSo f= a+ b;
            f.rutgon();
            
            f.Xuat();

            CPhanSo s;
            //cong
            s = a + b;
            Console.Write("Neu s= a+b thi : ");
            s.rutgon();
            s.Xuat();
            //tru
            s = a - b;
            Console.Write("Neu s= a-b thi : ");
            s.rutgon();
            s.Xuat();
            //nhan
            s = a * b;
            Console.Write("Neu s= a*b thi : ");
            s.rutgon();
            s.Xuat();
            //chia
            s = a / b;
            Console.Write("Neu s= a/b thi : ");
            s.rutgon();
            s.Xuat();

            Console.WriteLine("////////////////////////////////////////////////////////");

            Console.Write("Neu c =a+b thi : ");
            CPhanSo c = a + b;

            c.Xuat();
            Console.Write("Neu c =a-- thi : ");
            c = a--;
            c.Xuat();
            Console.Write("a = ");
            a.Xuat();
            // su khac biet neu phep tinh --
            Console.Write("Neu c = --a thi : ");
            c = --a;
            c.Xuat();
            Console.Write("a = ");
            a.Xuat();

            Console.Write("Neu c =a++ thi : ");
            c = a++;
            c.Xuat();
            Console.Write("a = ");
            a.Xuat();

            Console.Write("Neu c =++a thi : ");
            c = ++a;
            c.Xuat();
            Console.Write("a = ");
            a.Xuat();


            Console.WriteLine("////////////////////////////////////////////////////////");

            CPhanSo h = new CPhanSo(1, 2);
            h.tang1();
            h.Xuat();

            h.giam1();
            h.Xuat();
            Console.ReadLine();
        }
    }
}
