using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmplot.Classes
{
    class pMatrix
    {
        List<double> a;
        List<double> b;
        List<double> c;

        List<double> x;

        List<double> f;

        public pMatrix()
        {
        }

        public void init()
        {
            this.a = new List<double>();
            this.b = new List<double>();
            this.c = new List<double>();
            this.x = new List<double>();
            this.f = new List<double>();
        }

        public void setTest()
        {
            a.Add(0);
            a.Add(-2);
            a.Add(3);
            a.Add(1);

            b.Add(4);
            b.Add(2);
            b.Add(3);
            b.Add(-3);

            c.Add(1);
            c.Add(3);
            c.Add(1);
            c.Add(0);

            f.Add(2);
            f.Add(3);
            f.Add(12);
            f.Add(2);
        }

        public void setABCF(List<double> a, List<double> b, List<double> c, List<double> f)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.f = f;
        }

        public List<double> solveF()
        {
            this.x = new List<double>();

            int N = this.f.Count;

            List<double> L = new List<double>();
            List<double> M = new List<double>();

            for (int i = 0; i < N; i++)
            {
                L.Add(0); M.Add(0); this.x.Add(0);
            }

            if (this.b[0] != 0)
            {
                L[0] = this.c[0] / this.b[0];
                M[0] = this.f[0] / this.b[0];
            }

            double temp;
            for (int i = 1; i < N; i++)
            {
                temp = this.b[i] - this.a[i] * L[i - 1];
                if (temp != 0)
                {
                    L[i] = this.c[i] / temp;
                    M[i] = (this.f[i] - this.a[i] * M[i - 1]) / temp;
                }
            }
            this.x[N - 1] = M[N - 1];
            for (int i = N - 1; i > 0; i--)
            {
                this.x[i - 1] = M[i - 1] - L[i - 1] * this.x[i];
            }
            
            return this.x;
        }
    }
}
