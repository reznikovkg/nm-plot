using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmplot
{
    class IP
    {
        private double a;
        private double b;

        private int n;

        private List<double> X;
        private List<double> FX;

        private double tA;
        private double tB;

        public double Function(double x)
        {
            //return Math.Sin(x);
            //return x;
            //return 1 / (1 + 25 * x * x);
            return Math.Abs(x);
        }

        public IP()
        {
            this.a = -10;
            this.b = 10;

            this.n = 5;

            this.tA = 0;
            this.tB = 0;

            this.X = new List<double>();
            this.FX = new List<double>();


            this.SetX();
            this.SetFX();
        }
        
        ~IP()
        {

        }

        public void SetA(double _a)
        {
            this.a = _a;
        }

        public double GetA()
        {
            return this.a;
        }


        public void SetB(double _b)
        {
            this.b = _b;
        }

        public double GetB()
        {
            return this.b;
        }

        public void SetN(int _n)
        {
            this.n = _n;
        }

        public int GetN()
        {
            return this.n;
        }

        public void SetTA(double _tA)
        {
            this.tA = _tA;
        }

        public double GetTA()
        {
            return this.tA;
        }

        public void SetTB(double _tB)
        {
            this.tB = _tB;
        }

        public double GetTB()
        {
            return this.tB;
        }

        public void SetX()
        {
            for(int i = 0; i <= this.n; i++)
             {
                this.X.Add(a + (b - a) * i / n);
            }
        }

        public void SetFX()
        {
            for (int i = 0; i <= this.n; i++)
            {
                this.FX.Add(this.Function(this.X[i]));
            }
        }

        public void SetXFX()
        {
            for (int i = 0; i <= this.n; i++)
            {
                this.X.Add(a + (b - a) * i / n);
                this.FX.Add(this.Function(this.X[i]));
            }
        }
    }
}
