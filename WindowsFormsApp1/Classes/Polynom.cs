using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmplot.Classes
{
    class Polynom
    {
        private Func<string, int> f;

        private List<double> X;
        private List<double> FX;
        private List<double> H;

        private List<List<double>> coeffC;

        private List<double> A;
        private List<double> B;
        private List<double> C;
        private List<double> D;


        public Polynom()
        {
            this.X = new List<double>();
            this.FX = new List<double>();
            this.H = new List<double>();

            this.coeffC = new List<List<double>>();
            this.coeffC.Add(new List<double>());
            this.coeffC.Add(new List<double>());
            this.coeffC.Add(new List<double>());
            this.coeffC.Add(new List<double>());
        }

        public void SetPointsByFunction(Func<double,double> f, double a, double b, int n, string type = "norm")
        {
            switch (type)
            {
                case "norm":
                    {
                        double h = (b - a) / (n-1);
                        for (double i = a; i <= b; i += h)
                        {
                            this.X.Add(i);
                            this.FX.Add(f(i));
                            if (this.X.Count > 1)
                            {
                                this.H.Add(this.X[this.X.Count-1] - this.X[this.X.Count-2]);
                            }
                        }
                        break;
                    }
                case "cheb":
                    {
                        for (int i = 0; i <= n; i++)
                        {
                            double xi = (a + b) / 2 + (b - a) / 2 * Math.Cos((2 * i + 1) * Math.PI / (2 * n + 2));
                            //this.AddPoint(xi, f(xi));
                        }

                        break;
                    }
                default:
                    break;
            }
        }

        /*public void exam()
        {
            this.AddPoint(1, 1.0002);
            this.AddPoint(2, 1.0341);
            this.AddPoint(3, 0.6);
            this.AddPoint(4, 0.40105);
            this.AddPoint(5, 0.1);
            this.AddPoint(6, 0.23975);
        }*/

        /*public void AddPoint(double x, double y)
        {
            this.points.Add(new List<double>());
            points[points.Count - 1].Add(x);
            points[points.Count - 1].Add(y);
        }

        public double GetPoint(int x, int y)
        {
            return points[x][y];
        }
    
        public double GetH(int i)
        {
            return Math.Abs(this.GetPoint(i+1,0) - this.GetPoint(i, 0));
        }

        public int pointsCount()
        {
            return points.Count;
        }
        */
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

        public void setCoeffC(double A, double B)
        {
            /*this.AddCoeffС(
                0,
                2 * (this.GetH(0) + this.GetH(1)),
                this.GetH(1),
                3 * ((this.GetPoint(2, 1) - this.GetPoint(1, 1)) / this.GetH(1) - (this.GetPoint(1, 1) - this.GetPoint(0, 1)) / this.GetH(0))
                );*/

            /* this.AddCoeffС(
                 0,
                 -1,
                 1,
                 A*this.GetH(0)/3
                 );

             for (int i = 1; i < this.pointsCount()-1; i++)
             {
                 this.AddCoeffС(
                     this.GetH(i-1), 
                     2*(this.GetH(i - 1) + this.GetH(i)),
                     this.GetH(i), 
                     3*((this.GetPoint(i+1,1) - this.GetPoint(i, 1)) / this.GetH(i) - (this.GetPoint(i,1) - this.GetPoint(i-1,1)) / this.GetH(i-1))
                     );
             }*/

            /*this.AddCoeffС(
                this.GetH(this.pointsCount() - 3),
                2 * (this.GetH(this.pointsCount() - 3) + this.GetH(this.pointsCount() - 2)),
                this.GetH(this.pointsCount() - 2),
                3 * ((this.GetPoint(this.pointsCount() - 1, 1) - this.GetPoint(this.pointsCount() - 2, 1)) / this.GetH(this.pointsCount() - 2) - (this.GetPoint(this.pointsCount() - 2, 1) - this.GetPoint(this.pointsCount() - 3, 1)) / this.GetH(this.pointsCount() - 3))
                );*/

            // this.AddCoeffС(
            /*this.GetH(this.pointsCount()-2)* this.GetH(this.pointsCount() - 2)* this.GetH(this.pointsCount() - 2)/3,
            4* this.GetH(this.pointsCount() - 2)* this.GetH(this.pointsCount() - 2)/3,
            0,
            this.GetPoint(this.pointsCount()-1, 1) - 2* this.GetPoint(this.pointsCount()-2, 1) + this.GetPoint(this.pointsCount()-3, 1) - B*this.GetH(this.pointsCount() - 2)* this.GetH(this.pointsCount() - 2)/6
            */
            // 100,99999,0,20);

            /*this.AddCoeffС(
                    0,
                    -2,
                    this.GetH(1) / (this.GetH(0) + this.GetH(1)),
                    3 * ((this.GetPoint(2, 1) - this.GetPoint(1, 1)) / this.GetH(1) - (this.GetPoint(1, 1) - this.GetPoint(0, 1)) / this.GetH(0)) * (this.GetH(0) + this.GetH(1))
                    );

            for (int i = 1; i < this.pointsCount()-2; i++)
            {
                double hh = (this.GetH(i - 1) + this.GetH(i));

                this.AddCoeffС(
                    this.GetH(i - 1)/hh,
                    -2,
                    this.GetH(i)/hh,
                    3 * ((this.GetPoint(i + 1, 1) - this.GetPoint(i, 1)) / this.GetH(i) - (this.GetPoint(i, 1) - this.GetPoint(i - 1, 1)) / this.GetH(i - 1))*hh
                    );
            }

            this.AddCoeffС(
                   this.GetH(this.pointsCount() - 3) / (this.GetH(this.pointsCount() - 3) + this.GetH(this.pointsCount() - 2)),
                   -2,
                   0,
                   3 * ((this.GetPoint(this.pointsCount() - 1, 1) - this.GetPoint(this.pointsCount() - 2, 1)) / this.GetH(1) - (this.GetPoint(this.pointsCount() - 2, 1) - this.GetPoint(this.pointsCount() - 3, 1)) / this.GetH(0)) * (this.GetH(0) + this.GetH(1))
                   );*/

           this.AddCoeffC(
                0,
                2 * (this.H[0] * 2),
                this.H[0],
                3 * ((this.FX[1] - this.FX[0]) / this.H[0] - (this.FX[1] - this.FX[0]) / this.H[0])
                );

            for (int i = 1; i < this.H.Count-1; i++)
            {
                this.AddCoeffC(
                    this.H[i-1],
                    2*(this.H[i-1]+this.H[i]),
                    this.H[i],
                    3 * ((this.FX[i+1] - this.FX[i]) / this.H[i] - (this.FX[i] - this.FX[i-1]) / this.H[i-1])
                    );
            }

            this.AddCoeffC(
                this.H[this.H.Count - 1],
                2 * (this.H[this.H.Count - 1] * 2),
                0,
                3 * ((this.FX[this.H.Count] - this.FX[this.H.Count - 1]) / this.H[this.H.Count - 1] - (this.FX[this.H.Count - 1] - this.H[this.H.Count - 2]) / this.H[this.H.Count - 2])
                );
        }

        public void setCoeffSpline(double A, double B)
        {
            pMatrix coeff = new pMatrix();
            coeff.setABCF(this.GetCoeffC_A(), this.GetCoeffC_B(), this.GetCoeffC_C(), this.GetCoeffC_F());
            this.C = coeff.solveF();


        }


       /* public double pointSpline(double x, int i)
        {
            double xt = x - this.GetPoint(i,0);
            return this.a[i] + this.b[i] * xt + this.c[i] * xt*xt + this.d[i] * xt * xt * xt;
        }*/
    }
}
