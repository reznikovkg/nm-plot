using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmplot.Classes
{
    class Spline
    {
        private Func<double, double> f;

        private List<double> X;
        private List<double> FX;
        private List<double> H;

        private int n;

        private List<List<double>> coeffC;

        private List<double> A;
        private List<double> B;
        private List<double> C;
        private List<double> D;


        public Spline()
        {
            this.X = new List<double>();
            this.FX = new List<double>();
            this.H = new List<double>();

            this.coeffC = new List<List<double>>();
            this.coeffC.Add(new List<double>());
            this.coeffC.Add(new List<double>());
            this.coeffC.Add(new List<double>());
            this.coeffC.Add(new List<double>());
            
            this.A = new List<double>();
            this.B = new List<double>();
            this.C = new List<double>();
            this.D = new List<double>();
        }

        public void SetPointsByFunction(Func<double, double> ff, double a, double b, int nn, string type = "norm")
        {
            this.f = ff;
            this.n = nn;
            switch (type)
            {
                case "norm":
                    {
                        for (int i = 0; i <= n; i++)
                        {
                            this.X.Add(a + (b - a) * i / n);
                            this.FX.Add(this.f(this.X[i]));
                            if (i != 0)
                            {
                                this.H.Add(this.X[i] - this.X[i - 1]);
                            }
                        }
                        break;
                    }
                case "cheb":
                    {
                        for (int i = 0; i <= n; i++)
                        {
                            double xi = (a + b) / 2 + (b - a) / 2 * Math.Cos((2 * i + 1) * Math.PI / (2 * n + 2));
                            this.X.Add(xi);
                            this.FX.Add(this.f(xi));
                            if (i != 0)
                            {
                                this.H.Add(this.X[i] - this.X[i - 1]);
                            }
                        }

                        break;
                    }
                default:
                    break;
            }
        }

        public int CountX()
        {
            return this.X.Count;
        }

        public int CountFX()
        {
            return this.FX.Count;
        }

        public List<double> GetX()
        {
            return this.X;
        }

        public List<double> GetFX()
        {
            return this.FX;
        }

        public double GetX(int i)
        {
            return this.X[i];
        }

        public double GetFX(int i)
        {
            return this.FX[i];
        }

        public double GetH(int i)
        {
            return this.H[i];
        }


        public double GetN()
        {
            return this.n;
        }
        public void AddCoeffC(double a, double b, double c, double f)
        {
            coeffC[0].Add(a);
            coeffC[1].Add(b);
            coeffC[2].Add(c);
            coeffC[3].Add(f);
        }

        public List<double> GetCoeffC_A()
        {
            return this.coeffC[0];
        }

        public List<double> GetCoeffC_B()
        {
            return this.coeffC[1];
        }

        public List<double> GetCoeffC_C()
        {
            return this.coeffC[2];
        }

        public List<double> GetCoeffC_F()
        {
            return this.coeffC[3];
        }

        public void setCoeffB()
        {
            for (int i = 1; i < n; i++)
            {
                this.AddCoeffC(
                    this.H[i - 1],

                    2 * (this.H[i] + this.H[i - 1]),
                    this.H[i],
                    3 * ((this.FX[i + 1] - this.FX[i]) / this.H[i] - (this.FX[i] - this.FX[i - 1]) / this.H[i - 1])
                    );
            }
        }

        public void setCoeffSpline(double tA, double tB)
        {
            pMatrix coeff = new pMatrix();

            coeff.setABCF(this.GetCoeffC_A(), this.GetCoeffC_B(), this.GetCoeffC_C(), this.GetCoeffC_F());

            List<double> CC = coeff.solveF();

            this.C.Add(CC[0] - tA / 3);


            for (int i = 0; i < this.n - 1; i++)
            {
                this.C.Add(CC[i]);
            }

            this.A = this.FX;
            

            this.D.Add(tA / 6);
            this.C.Add(tB / 2);
            //this.D.Add((this.C[1] - this.C[0]) / (3 * this.H[0]));

            this.B.Add((this.FX[1] - this.FX[0]) / this.H[0] - this.H[0] * (2 * this.C[0] + this.C[1]) / 3);

            for (int i = 1; i < this.n; i++)
            {
                this.B.Add((this.FX[i + 1] - this.FX[i]) / this.H[i] - this.H[i] * (2 * this.C[i] + this.C[i + 1]) / 3);
                this.D.Add((this.C[i + 1] - this.C[i]) / (3 * this.H[i]));
            }
        }


        public double pointSpline(double x)
        {
            int i = 0;
            bool ost = true;

            while (ost)
            {
                if ((i<this.X.Count-1)&&(this.X[i] <= x) && (this.X[i+1] >x))
                {
                    ost = false;
                } else {
                    i++;
                }
            }

            double xt = x - this.X[i];
            return this.A[i] + this.B[i] * xt + this.C[i] * xt * xt + this.D[i] * xt * xt * xt;

        }
    }
}
