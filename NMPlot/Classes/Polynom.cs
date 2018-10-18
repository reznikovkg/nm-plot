using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmplot.Classes
{
    class Polynom
    {
        private List<List<double>> points;
        private int n;
        private List<List<double>> diff;

        // Construct
        public Polynom() { }
        public Polynom(List<List<double>> _points)
        {
            points = _points;
            n = points[0].Count;
            diff = new List<List<double>>();
            setDiff();
        }

        //points methods
        public double getPointX(int i)
        {
            return points[0][i];
        }

        public double getPointY(int i)
        {
            return points[1][i];
        }

        //Diff table
        /*void setDiff()
        {
            for (int i = 0; i < n; i++)
            {
                diff.Add(new List<double>());
                
                for (int j = i + 1; j < n; j++)
                {
                    diff[i].Add(getDiffSum(i, j));
                }
            }
        }*/
        void setDiff()
        {
            diff.Add(new List<double>());

            for (int i = 1; i < n; i++) // *(n)
            {
                diff[0].Add(getDiffSum(0, i));
            }
        }
        double getDiffSum(int _i, int _j)
        {
            double sum = 0;
            for (int i = _i; i <= _j; i++) // n
            {
                sum += (getPointY(i) / getDiffProd(i, _i, _j)); // 2
            }
            return sum;
        }

        double getDiffProd(int _i, int __i, int __j)
        {
            double prod = 1;
            for (int _j = __i; _j <= __j; _j++) // n!
            {
                if (_j != _i) 
                {
                    prod *= (getPointX(_i) - getPointX(_j)); // 2
                }
            }
            return prod;
        }


        //spline out - P(x)
        public double pointPolynom(double x)
        {
            return getPointY(0) + pRec(x, 1, n);
        }

        double pRec(double x, int k, int ipn_n)
        {
            double result = 0;
            if (k < ipn_n)
            {
                result = diff[0][k-1];
                result *= pRecProd(x, k);
                result += pRec(x, k + 1, ipn_n);
            }
            return result;
        }

        double pRecProd(double x, int k)
        {
            double result = 1;
            for (int i = 0; i < k; i++)
            {
                result *= (x - getPointX(i));
            }
            return result;
        }
    }
}
