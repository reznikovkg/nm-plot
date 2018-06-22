using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using nmplot.Classes;
using OxyPlot;
using OxyPlot.Series;

namespace nmplot
{
    using System;
    using System.Windows.Forms;

    using OxyPlot;
    using OxyPlot.Series;

    public partial class Form1 : Form
    {
        private IP initial;

        private List<double> X;
        private List<double> Y;

        private Spline spline;
        private Polynom polynom;

        double tError;

        public Form1()
        {
            InitializeComponent();
            
            initial = new IP();
            
            this.loadPlotFromFunction();
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


        public void loadPlotFromFunction()
        {
            spline = new Spline();
            polynom = new Polynom();

            for (double i = initial.GetA() - 10; i < initial.GetB() + 10; i += 0.01)
            {
                chart_plot.Series[0].Points.AddXY(i, initial.Function(i));
            }

            //spline
            {
                spline.SetPointsByFunction(initial.Function, initial.GetA(), initial.GetB(), initial.GetN());
                spline.setCoeffB();
                spline.setCoeffSpline(initial.GetTA(), initial.GetTB());

                this.tError = 0;

                for (int i = 0; i <= spline.GetN(); i++)
                {
                    chart_plot.Series[1].Points.AddXY(spline.GetX(i), spline.GetFX(i));
                }

                for (double j = 0; j < 10; j += 0.001)
                {
                    chart_plot.Series[2].Points.AddXY(j, spline.pointSpline(j));

                    double t = Math.Abs(initial.Function(j) - spline.pointSpline(j));
                    if ((t > this.tError)) this.tError = t;
                }
            }

            //ploynom
            {
                List<List<double>> pp1 = new List<List<double>>();
                pp1.Add(spline.GetX());
                pp1.Add(spline.GetFX());


                polynom = new Polynom(pp1);
                for (double j = 0; j < 10; j += 0.001)
                {
                    chart_plot.Series[3].Points.AddXY(j, polynom.pointPolynom(j));

                }
            }

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            var pm = new PlotModel
            {
                Title = "NM PLOT",
                PlotType = PlotType.Cartesian,
                Background = OxyColors.White
            };
            pm.Series.Add(new FunctionSeries(Math.Sin, initial.GetA(), initial.GetB(), 0.01, "Sin(x)"));
            
            pm.Series.Add(new FunctionSeries(polynom.pointPolynom, initial.GetA(), initial.GetB(), 0.2, "P(x)"));
            pm.Series.Add(new FunctionSeries(spline.pointSpline, initial.GetA(), initial.GetB(), 0.1, "S(x)"));

            oxy_plot.Model = pm;
        }

        public void loadPlotFromPoints()
        {
            spline = new Spline();
            polynom = new Polynom();
            
            chart_plot.Series[0].Points.Clear();

            //spline
            {
                spline.SetPoints(this.X, this.Y);
                spline.setCoeffB();
                spline.setCoeffSpline(initial.GetTA(), initial.GetTB());

                this.tError = 0;

                for (int i = 0; i <= spline.GetN(); i++)
                {
                    chart_plot.Series[1].Points.AddXY(spline.GetX(i), spline.GetFX(i));
                }

                for (double j = 0; j < 10; j += 0.001)
                {
                    chart_plot.Series[2].Points.AddXY(j, spline.pointSpline(j));

                    double t = Math.Abs(initial.Function(j) - spline.pointSpline(j));
                    if ((t > this.tError)) this.tError = t;
                }
            }

            //ploynom
            {
                List<List<double>> pp1 = new List<List<double>>();
                pp1.Add(spline.GetX());
                pp1.Add(spline.GetFX());


                polynom = new Polynom(pp1);
                for (double j = 0; j < 10; j += 0.001)
                {
                    chart_plot.Series[3].Points.AddXY(j, polynom.pointPolynom(j));

                }
            }

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            var pm = new PlotModel
            {
                Title = "NM PLOT",
                PlotType = PlotType.Cartesian,
                Background = OxyColors.White
            };
            pm.Series.Add(new FunctionSeries(Math.Sin, initial.GetA(), initial.GetB(), 0.01, "Sin(x)"));

            pm.Series.Add(new FunctionSeries(polynom.pointPolynom, initial.GetA(), initial.GetB(), 0.2, "P(x)"));
            pm.Series.Add(new FunctionSeries(spline.pointSpline, initial.GetA(), initial.GetB(), 0.1, "S(x)"));

            oxy_plot.Model = pm;
        }

        public void clearPlot()
        {
            chart_plot.Series[3].Points.Clear();
            chart_plot.Series[2].Points.Clear();


            var pm = new PlotModel
            {
                Title = "NM PLOT",
                PlotType = PlotType.Cartesian,
                Background = OxyColors.White
            };

            oxy_plot.Model = pm;
        }

        ///////////////
        //
        //     Menu
        //
        ///////////////

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        


        ///////////////
        //
        //     Chart
        //
        ///////////////

        void chart_Click(object sender, EventArgs e)
        {
            //chart_plot.Series[1].Points.AddXY(13, 13);
        }

        ///////////////
        //
        //     Options tabs/Show/Hide
        //
        ///////////////

        private void checkBox_All(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked == true)
            {
                chart_plot.Series[0].Enabled = true;
                checkBoxFunction.Checked = true;

                chart_plot.Series[1].Enabled = true;
                checkBoxPoints.Checked = true;

                chart_plot.Series[2].Enabled = true;
                checkBoxSpline.Checked = true;

                chart_plot.Series[3].Enabled = true;
                checkBoxPolynom.Checked = true;
            }
            else
            {
                chart_plot.Series[0].Enabled = false;
                checkBoxFunction.Checked = false;

                chart_plot.Series[1].Enabled = false;
                checkBoxPoints.Checked = false;

                chart_plot.Series[2].Enabled = false;
                checkBoxSpline.Checked = false;

                chart_plot.Series[3].Enabled = false;
                checkBoxPolynom.Checked = false;
            }
        }

        private void checkBox_Function(object sender, EventArgs e)
        {
            if (checkBoxFunction.Checked == true)
            {
                chart_plot.Series[0].Enabled = true;
            }
            else
            {
                chart_plot.Series[0].Enabled = false;
            }
        }

        private void checkBox_Points(object sender, EventArgs e)
        {
            if (checkBoxPoints.Checked == true)
            {
                chart_plot.Series[1].Enabled = true;
            }
            else
            {
                chart_plot.Series[1].Enabled = false;
            }
        }

        private void checkBox_Spline(object sender, EventArgs e)
        {
            if (checkBoxSpline.Checked == true)
            {
                chart_plot.Series[2].Enabled = true;
            }
            else
            {
                chart_plot.Series[2].Enabled = false;
            }
        }

        private void checkBox_Polynom(object sender, EventArgs e)
        {
            if (checkBoxPolynom.Checked == true)
            {
                chart_plot.Series[3].Enabled = true;
            }
            else
            {
                chart_plot.Series[3].Enabled = false;
            }
        }








        ///////////////
        //
        //     Options tabs/T/B/L/R
        //
        ///////////////

        private void buttonSetTBLR_Click(object sender, EventArgs e)
        {
            double L = 10;
            double R = 10;
            double T = 10;
            double B = 10;

            if ((textBoxL.Text != "") && (textBoxR.Text != ""))
            {
                Double.TryParse(textBoxL.Text, out L);
                Double.TryParse(textBoxR.Text, out R);

                chart_plot.ChartAreas[0].AxisX.ScaleView.Zoom(L, R);
            }
            if ((textBoxT.Text != "") && (textBoxB.Text != ""))
            {
                Double.TryParse(textBoxT.Text, out T);
                Double.TryParse(textBoxB.Text, out B);

                chart_plot.ChartAreas[0].AxisY.ScaleView.Zoom(B, T);
            }
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
        }
        

        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NM-Plot");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //chart_plot.ChartAreas[0].AxisX.ScaleView.Zoom(1.98, 2.02);
        }


        private void initial_param_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart_plot_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show((e.X).ToString());
            var res = chart_plot.HitTest(e.X, e.Y);
            //if (res.Series != null)
              //  MessageBox.Show(res.Series.Points[res.PointIndex].YValues[0].ToString());
        }

        private void plot1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chart_plot.Series[1].Points.Clear();
            this.X = new List<double>();
            this.Y = new List<double>();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double x;
            Double.TryParse(xAddOxyplot.Text, out x);
            this.X.Add(x);
            xAddOxyplot.Text = "";

            double y;
            Double.TryParse(yAddOxyplot.Text, out y);
            this.Y.Add(y);
            yAddOxyplot.Text = "";

            chart_plot.Series[1].Points.AddXY(x,y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearPlot();
            loadPlotFromPoints();
        }
    }
}
