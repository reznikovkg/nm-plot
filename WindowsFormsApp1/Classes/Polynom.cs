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
        private List<List<double>> points;
        private List<List<double>> coeffС;
        private List<List<double>> coeffSpline;


        public Polynom()
        {
            this.points = new List<List<double>>();
            this.coeffС = new List<List<double>>();
            this.coeffSpline = new List<List<double>>();
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
                            this.AddPoint(i, f(i));
                        }
                        break;
                    }
                case "cheb":
                    {
                        for (int i = 0; i <= n; i++)
                        {
                            double xi = (a + b) / 2 + (b - a) / 2 * Math.Cos((2 * i + 1) * Math.PI / (2 * n + 2));
                            this.AddPoint(xi, f(xi));
                        }

                        break;
                    }
                default:
                    break;
            }
        }

        public void AddPoint(double x, double y)
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

        public void AddCoeffС(double a, double b, double c, double d)
        {
            this.coeffС.Add(new List<double>());
            coeffС[coeffС.Count - 1].Add(a);
            coeffС[coeffС.Count - 1].Add(b);
            coeffС[coeffС.Count - 1].Add(c);
            coeffС[coeffС.Count - 1].Add(d);
        }

        public void setCoeffC(double A, double B)
        {
            /*this.AddCoeffС(
                0,
                2 * (this.GetH(0) + this.GetH(1)),
                this.GetH(1),
                3 * ((this.GetPoint(2, 1) - this.GetPoint(1, 1)) / this.GetH(1) - (this.GetPoint(1, 1) - this.GetPoint(0, 1)) / this.GetH(0))
                );*/

            this.AddCoeffС(
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
                    3*((this.GetPoint(i+1,1) - this.GetPoint(i, 1)) / this.GetH(i) - (this.GetPoint(i,1)- this.GetPoint(i-1,1)) / this.GetH(i-1))
                    );
            }

            /*this.AddCoeffС(
                this.GetH(this.pointsCount() - 3),
                2 * (this.GetH(this.pointsCount() - 3) + this.GetH(this.pointsCount() - 2)),
                this.GetH(this.pointsCount() - 2),
                3 * ((this.GetPoint(this.pointsCount() - 1, 1) - this.GetPoint(this.pointsCount() - 2, 1)) / this.GetH(this.pointsCount() - 2) - (this.GetPoint(this.pointsCount() - 2, 1) - this.GetPoint(this.pointsCount() - 3, 1)) / this.GetH(this.pointsCount() - 3))
                );*/

            this.AddCoeffС(
                this.GetH(this.pointsCount()-2)* this.GetH(this.pointsCount() - 2)* this.GetH(this.pointsCount() - 2)/3,
                4* this.GetH(this.pointsCount() - 2)* this.GetH(this.pointsCount() - 2)/3,
                0,
                this.GetPoint(this.pointsCount()-1, 1) - 2* this.GetPoint(this.pointsCount()-2, 1) + this.GetPoint(this.pointsCount()-3, 1) - B*this.GetH(this.pointsCount() - 2)* this.GetH(this.pointsCount() - 2)/6
                );

        }

        public void solveCoeffC()
        {
            /*for (int i = 0; i < this.pointsCount()-1; i++)
            {
                this.coeffSpline.Add(new List<double>());
                coeffSpline[coeffSpline.Count - 1].Add(0);
                coeffSpline[coeffSpline.Count - 1].Add(0);
                coeffSpline[coeffSpline.Count - 1].Add(0);
                coeffSpline[coeffSpline.Count - 1].Add(0);
            }

            double m;

            for (int i = 1; i < this.pointsCount()-1; i++)
            {
                m = this.coeffС[i][0] / this.coeffС[i - 1][1];
                this.coeffС[i][1] = this.coeffС[i][1] - m * this.coeffС[i - 1][2];
                this.coeffС[i][3] = this.coeffС[i][3] - m * this.coeffС[i - 1][3];
            }

            this.coeffSpline[this.pointsCount() - 2][2] = this.coeffС[this.pointsCount() - 2][3] / this.coeffС[this.pointsCount() - 2][1];

            for (int i = this.pointsCount() -2; i>=0;i--)
            {
                this.coeffSpline[i-1][2] = (this.coeffС[i][3] - this.coeffС[i][2] * this.coeffSpline[i][2]) / this.coeffС[i][1];
            }*/

            /*List<double> p = new List<double>();
            List<double> q = new List<double>();
            p.Add(this.coeffС[0][2]/ this.coeffС[0][1]);
            q.Add(- this.coeffС[0][3] / this.coeffС[0][1]);

            for (int i = 1; i < this.pointsCount(); i++)
            {
                p.Add(this.coeffС[i][2]/(this.coeffС[i][1]-this.coeffС[i][0]*p[i-1]));
                q.Add((this.coeffС[i][0] * q[i - 1] - this.coeffС[i][3]) / (this.coeffС[i][1]));
            }

            this.coeffSpline[this.pointsCount() - 1][2] = this.coeffС[this.pointsCount() - 1][3] / this.coeffС[this.pointsCount() - 1][1];

            for (int i = this.pointsCount() - 2; i >= 0; i--)
            {
                this.coeffSpline[i][2] = (this.coeffС[i][3] - this.coeffС[i][2] * this.coeffSpline[i + 1][2]) / this.coeffС[i][1];
            }*/


            int N = this.pointsCount();
            List<double> L = new List<double>();
            List<double> M = new List<double>();
            List<double> X = new List<double>();
            for (int i = 0; i < N; i++)
            {
                L.Add(0);  M.Add(0);  X.Add(0);
            }

            if ( this.coeffС[0][1] !=0 )
            {
                L[0] = this.coeffС[0][2] / this.coeffС[0][1];
                M[0] = this.coeffС[0][3] / this.coeffС[0][1];
            }

            double temp;
            for (int i = 1; i < N; i++)
            {
                temp = this.coeffС[i][1] - this.coeffС[i][0] * L[i-1];
                if (temp != 0)
                {
                    L[i] = this.coeffС[i][2]/temp;
                    M[i] = (this.coeffС[i][3] - this.coeffС[i][0]*M[i-1]) / temp;
                }
            }
            X[N - 1] = M[N - 1];
            for (int i = N-1; i > 0; i--)
            {
                X[i - 1] = M[i - 1] - L[i - 1] * X[i];
            }

            for (int i = 0; i < N; i++)
            {
                this.coeffSpline.Add(new List<double>());
                coeffSpline[coeffSpline.Count - 1].Add(0);
                coeffSpline[coeffSpline.Count - 1].Add(0);
                coeffSpline[coeffSpline.Count - 1].Add(X[i]);
                coeffSpline[coeffSpline.Count - 1].Add(0);
            }
        }

        public void setCoeffSpline()
        {
            int N = this.pointsCount() - 1;
            for (int i = 0; i < N; i++)
            {
                this.coeffSpline[i][0] = this.GetPoint(i, 1);
                this.coeffSpline[i][1] = (this.GetPoint(i + 1, 1) - this.GetPoint(i, 1)) / GetH(i) - (2 / 3) * this.coeffSpline[i][2] * GetH(i) - this.coeffSpline[i + 1][2] * GetH(i) / 3;
                this.coeffSpline[i][3] = (this.coeffSpline[i + 1][2] - this.coeffSpline[i][2]) / (3*GetH(i));
            }

            this.coeffSpline[N][0] = this.GetPoint(N, 1)+200;
            this.coeffSpline[N][1] = this.coeffSpline[N-1][1] +2*this.coeffSpline[N-1][2]*this.GetH(N - 1) + 3*this.coeffSpline[N-1][3]*this.GetH(N-1)* this.GetH(N - 1);
            this.coeffSpline[N][3] = 100;
        }


        public double pointSpline(double x, int i)
        {
            double xt = x - this.GetPoint(i,0);
            return this.coeffSpline[i][0] + this.coeffSpline[i][1] * xt + this.coeffSpline[i][2] * xt * xt + this.coeffSpline[i][3] * xt * xt * xt;
        }
    }
}
