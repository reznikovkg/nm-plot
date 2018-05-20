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

        
        public IP()
        {
            this.a = 3;
            this.b = 12;
        }

        public double f(double x)
        {
            return Math.Cos(x);
        }

        public double s(double a, double b, double c, double d, double x, double xi)
        {
            double xt = x - xi;
            return a + b * xt + c * xt * xt + d * xt * xt * xt;
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
    }
}
