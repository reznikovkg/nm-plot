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

        public Polynom()
        {
            this.points = new List<List<double>>();
        }

        public void SetPointsByFunction(Func<double> f, double a, double b, double n, string type)
        {
            switch (type)
            {
                case "normal":
                    {
                        break;
                    }
                case "cheb":
                    {
                        break;
                    }
                default:
                    break;
            }

            for (int i = 0; i < n; i++)
            {
                this.AddPoint(1, 1);
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

    }
}
