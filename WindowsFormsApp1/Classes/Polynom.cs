﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmplot.Classes
{
    class Polynom
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


            this.A = new List<double>();
            this.B = new List<double>();
            this.C = new List<double>();
            this.D = new List<double>();
        }

        public void SetPointsByFunction(Func<double,double> ff, double a, double b, int nn, string type = "norm")
        {
            this.f = ff;
            this.n = nn;
            switch (type)
            {
                case "norm":
                    {
                        //double h = (b - a) / (n-1);
                        for (int i = 0; i <= n; i ++)
                        {
                            this.X.Add(a + (b-a)*i/n);
                            this.FX.Add(this.f(this.X[i]));
                            if (i!=0)
                            {
                                this.H.Add(this.X[i]-this.X[i-1]);
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
        */
        public int CountX()
        {
            return this.X.Count;
        }

        public int CountFX()
        {
            return this.FX.Count;
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

        public void setCoeffC()
        {
            for (int i = 1; i < n; i++)
            {
                this.AddCoeffC(
                    this.H[i-1],
                    2 * (this.H[i] + this.H[i-1]),
                    this.H[i],
                    3 * ((this.FX[i + 1] - this.FX[i]) / this.H[i] - (this.FX[i] - this.FX[i - 1]) / this.H[i - 1])
                    );
            }
            /*this.AddCoeffC(
                this.H[last-1],
                2 * (this.H[last-1] + this.H[last-1]),
                this.H[last-1],
                    3 * (
                    (this.f( this.X[last] + this.H[last-1] ) - this.FX[last]) / this.H[this.X.Count - 2]
                    -
                    (this.FX[this.X.Count - 1] - this.FX[this.X.Count - 2]) / this.H[this.X.Count - 2]
                    )
                );*/
        }

        public void setCoeffSpline(double tA, double tB)
        {
            pMatrix coeff = new pMatrix();
            coeff.setABCF(this.GetCoeffC_A(), this.GetCoeffC_B(), this.GetCoeffC_C(), this.GetCoeffC_F());

            List<double> CC = coeff.solveF();

            this.C.Add(CC[0]-tA/3);
                

            for (int i = 0; i < this.n-1; i++)
            {
                this.C.Add(CC[i]);
            }

            this.A = this.FX;



            /*this.D.Add(tA / 6);
            //this.D.Add((this.C[1] - this.C[0]) / (3 * this.H[0]));

            this.B.Add((this.FX[1] - this.FX[0]) / this.H[0] - this.H[0] * (2 * this.C[0] + this.C[1]) / 3);


            int last_i = 0;
            for (int i = 1; i< this.C.Count-1; i++)
            {
                this.B.Add( (this.FX[i+1]-this.FX[i])/this.H[i] - this.H[i]*(2*this.C[i] + this.C[i+1])/3 );
                this.D.Add((this.C[i + 1] - this.C[i]) / (3 * this.H[i]));
                last_i = i;
            }
            last_i++;
            
            this.B.Add( this.B[last_i-1] + this.C[last_i-1]*this.H[last_i-1] + this.C[last_i]* this.H[last_i - 1]);
            this.D.Add( (tB - 2*this.C[last_i])/(6*this.H[last_i]) );*/





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


        public double pointSpline(double x, int i)
        {
            double xt = x - this.X[i];
            return this.A[i] + this.B[i] * xt + this.C[i] * xt*xt + this.D[i] * xt * xt * xt;
        }
    }
}
