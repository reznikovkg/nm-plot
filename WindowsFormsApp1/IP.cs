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

        private double tA;
        private double tB;

        public double Function(double x)
        {
            return Math.Sin(x);
            //return x * x *x;
            //return 1 / (1 + 25 * x * x);
            //return Math.Abs(x);
        }

        public double Spline(double a, double b, double c, double d, double x, double xi)
        {
            double xt = x - xi;
            return a + b * xt + c * xt * xt + d * xt * xt * xt;
        }


        public IP()
        {
            this.a = 0;
            this.b = 10;

            this.n = 10;

            this.tA = 0;
            this.tB = 0;
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
    }
}
