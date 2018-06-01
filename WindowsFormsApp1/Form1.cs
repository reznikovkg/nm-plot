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

namespace nmplot
{
    public partial class Form1 : Form
    {
        private IP initial;
        private Spline polynom;

        double tError;

       


        public Form1()
        {
            InitializeComponent();
            initial = new IP();
            polynom = new Spline();
            

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

        

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "dsadsa";
        }

        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("топовая прога");
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
    }
}
