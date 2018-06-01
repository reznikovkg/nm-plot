using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nmplot.Classes;

namespace nmplot
{
    public partial class Form1 : Form
    {
        private IP initial;
        private Polynom polynom;

        double tError;

        public Form1()
        {
            InitializeComponent();
            initial = new IP();
            polynom = new Polynom();
            

            polynom.SetPointsByFunction(initial.Function, initial.GetA(), initial.GetB(), initial.GetN());
            polynom.setCoeffB();
            polynom.setCoeffSpline(initial.GetTA(), initial.GetTB());

            /*polynom.exam();
            polynom.setCoeffC(initial.GetTA(), initial.GetTB());
            polynom.solveCoeffC();
            polynom.setCoeffSpline(initial.GetTA(), initial.GetTB());

            chart_plot.Series[0].Enabled = true;
            chart_plot.Series[1].Enabled = true;
            */
            for (double i = initial.GetA()-10; i < initial.GetB()+10; i+=0.01)
            {
                chart_plot.Series[0].Points.AddXY(i, initial.Function(i));
            }

            for (int i = 0; i <= polynom.GetN(); i ++)
            {
                chart_plot.Series[1].Points.AddXY(polynom.GetX(i), polynom.GetFX(i));
            }


            this.tError = 0;
            for (int i = 0; i <= polynom.GetN()-1; i++)
            {
                for (double j = polynom.GetX(i); j < polynom.GetX(i + 1); j += 0.001)
                {
                    chart_plot.Series[2].Points.AddXY(j, polynom.pointSpline(j,i));

                    double t = Math.Abs(initial.Function(j) - polynom.pointSpline(j, i));
                    if ((t > this.tError)) this.tError = t;
                }
            }


            label3.Text = (this.tError).ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chart_plot.ChartAreas[0].AxisX.ScaleView.Zoom(1.98, 2.02);
            chart_plot.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart_plot.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart_plot.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart_plot.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            //chart_plot.ChartAreas[0].AxisY.ScaleView.Zoom(0.85, 0.95);
            chart_plot.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart_plot.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart_plot.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart_plot.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

        }
        
        private void chart_Click(object sender, EventArgs e)
        {
            //chart_plot.Series[1].Points.AddXY(13, 13);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PlotInitFunc();

            chart_plot.Series[0].Enabled = true;
        }

        private void PlotPointsFunction(IP init)
        {

           /* for (double i = Prop.GetA(); i < Prop.GetB(); i += 0.01)
            {
                chart_plot.Series[0].Points.AddXY(i, Math.Cos(i));
            }*/
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button_Rebuild(object sender, EventArgs e)
        {
            chart_plot.Series[0].Points.Clear();

           /* if (initial_param_a.Text.Length > 0)
            {
                Prop.SetA(double.Parse(initial_param_a.Text));
            }
            if (initial_param_b.Text.Length > 0)
            {
                Prop.SetB(double.Parse(initial_param_b.Text));
            }*/

            
            
        }

        private void checkBox_Function(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                chart_plot.Series[0].Enabled = true;
            }
            else
            {
                chart_plot.Series[0].Enabled = false;
            }
        }

        private void checkBox_Spline(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                chart_plot.Series[1].Enabled = true;
            }
            else
            {
                chart_plot.Series[1].Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "dsadsa";
        }
    }
}
