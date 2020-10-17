using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class PTB2
    {
        private int i_a;
        private int i_b;
        private int i_c;
        private float i_d;
        private float i_x1;
        private float i_x2;
        public int soA
        {
            get { return i_a; }
            set { i_a = value; }
        }
        public int soB
        {
            get { return i_b; }
            set { i_b = value; }
        }
        public int soC
        {
            get { return i_c; }
            set { i_c = value; }
        }
        public float delta
        {
            get { return i_d; }
            set { i_d = value; }
        }
        public float x1
        {
            get { return i_x1; }
            set { i_x1 = value; }
        }
        public float x2
        {
            get { return i_x2; }
            set { i_x2 = value; }
        }
        public PTB2()
        {

        }
        public PTB2(int a, int b, int c,float d,float x1,float x2)
        {
            this.soA = a;
            this.soB = b;
            this.soC = c;
            this.delta = d;
            this.i_x1 = x1;
            this.i_x2 = x2;
        }

        public static PTB2 giai(PTB2 x)
        {
            PTB2 f = new PTB2();
            f.delta = x.i_b * x.i_b - 4 * x.i_a * x.i_c;
            if (f.delta == 0)
            {
                Console.Write("Phuong trinh co mot nghiem duy nhat.\n");
                f.i_x1 = -x.i_b / (2f * x.i_a);
                f.i_x2 = f.i_x1;
                Console.Write("Nghiem duy nhat cua phuong trinh la = {0}\n", f.i_x1);
            }
            else if (f.delta > 0)
            {
                Console.Write("Phuong trinh co hai nghiem thuc phan biet\n");

                f.i_x1 = (-x.i_b + (float)Math.Sqrt(f.delta)) / (2f * x.i_a);
                f.i_x2 = (-x.i_b - (float)Math.Sqrt(f.delta)) / (2f * x.i_a);

                Console.Write("Nghiem thu nhat: x1 = {0}\n", f.i_x1);
                Console.Write("Nghiem thu nhat: x2 = {0}\n", f.i_x2);
            }
            else
                Console.Write("Phuong trinh vo nghiem (hay khong co nghiem thuc nao)\n\n");
            return f;
        }

        public void XuatPTB2()
        {

            Console.Write(this.i_a.ToString() +"x2 +" + this.i_b.ToString()+"x=" + this.i_c.ToString());

            Console.WriteLine();
        }
    }
}
