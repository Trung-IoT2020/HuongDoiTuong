using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class CPhanSo
    {

        private int i_tuSo;
        private int i_mauSo;

        public int TuSo
        {
            get { return i_tuSo; }
            set { i_tuSo = value; }
        }
        public int MauSo
        {
            get { return i_mauSo; }
            set { i_mauSo = value; }
        }

        public CPhanSo()
        {
            i_tuSo = 0;
            i_mauSo = 1;
        }
        ~CPhanSo()
        {

        }
        public CPhanSo(int a, int b)
        {
            this.TuSo = a;
            this.MauSo = b;
        }

        public static CPhanSo operator --(CPhanSo b)
        {
            return new CPhanSo(b.TuSo - b.MauSo, b.MauSo);
        }
        public static CPhanSo operator ++(CPhanSo b)
        {
            return new CPhanSo(b.TuSo + b.MauSo, b.MauSo);
        }
        //CONG
        public static CPhanSo cong(CPhanSo a, CPhanSo b)
        {
            CPhanSo s = new CPhanSo();
            s.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            s.MauSo = a.MauSo * b.MauSo;
            return s;
        }
        //HIEU
        public static CPhanSo hieu(CPhanSo a, CPhanSo b)
        {
            CPhanSo s = new CPhanSo();
            s.TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
            s.MauSo = a.MauSo * b.MauSo;
            return s;
        }
        //NHAN
        public static CPhanSo tich(CPhanSo a, CPhanSo b)
        {
            CPhanSo s = new CPhanSo();
            s.TuSo = a.TuSo * b.TuSo;
            s.MauSo = a.MauSo * b.MauSo;
            return s;
        }
        //CHiA
        public static CPhanSo thuong(CPhanSo a, CPhanSo b)
        {
            CPhanSo s = new CPhanSo();
            s.TuSo = a.TuSo * b.MauSo;
            s.MauSo = a.MauSo * b.TuSo;
            return s;
        }




        public static CPhanSo operator +(CPhanSo a, CPhanSo b)
        {
            return cong(a , b);
        }
        public static CPhanSo operator -(CPhanSo a, CPhanSo b)
        {
            return thuong(a, b);
        }
        public static CPhanSo operator *(CPhanSo a, CPhanSo b)
        {
            return tich(a, b);
        }
        public static CPhanSo operator /(CPhanSo a,CPhanSo b)
        {
            return thuong(a, b); 
        }


        public void Xuat()
        {
            
            Console.Write(this.i_tuSo.ToString() + "/" + this.i_mauSo.ToString());
            
            Console.WriteLine();
        }
        //ham rut gon
        public void rutgon()
        {
            if (i_tuSo ==0)
            {
                i_mauSo = 1;
            }
            else if (i_mauSo ==0)
            {
                i_tuSo = 0;
                i_mauSo = 1;
            }
            else
            {
                if(i_mauSo == 0)
                {
                    i_mauSo = -i_mauSo;
                    i_tuSo = -i_tuSo;
                }
                int a = Math.Abs(i_tuSo);
                int b = Math.Abs(i_mauSo);
                while(a!=b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                i_mauSo /= a;
                i_tuSo /= a;

            }
        }
        public void giam1()
        {

            i_tuSo -= 1;
            i_mauSo -= 1;
        }

        public void tang1()
        {
            i_tuSo += 1;
            i_mauSo += 1;

        }
    }
}
