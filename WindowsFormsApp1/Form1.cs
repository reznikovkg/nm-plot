using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private IP Prop;

        public Form1()
        {
            InitializeComponent();
            Prop = new IP();
            PlotInitFunc();

            chart_plot.Series[0].Enabled = true;
            chart_plot.Series[1].Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart_plot.ChartAreas[0].AxisX.ScaleView.Zoom(0, 50);
            chart_plot.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart_plot.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart_plot.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart_plot.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart_plot.ChartAreas[0].AxisY.ScaleView.Zoom(-1, 20);
            chart_plot.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart_plot.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart_plot.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart_plot.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

        }
        
        private void chart_Click(object sender, EventArgs e)
        {
            chart_plot.Series[1].Points.AddXY(13, 13);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PlotInitFunc();

            chart_plot.Series[0].Enabled = true;
        }

        public void PlotInitFunc()
        {

            for (double i = Prop.GetA(); i < Prop.GetB(); i += 0.01)
            {
                chart_plot.Series[0].Points.AddXY(i, Math.Cos(i));
            }

            for (double i = Prop.GetA(); i < Prop.GetB(); i += 0.01)
            {
                chart_plot.Series[1].Points.AddXY(i, Math.Sin(i));
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button_Rebuild(object sender, EventArgs e)
        {
            chart_plot.Series[0].Points.Clear();

            if (initial_param_a.Text.Length > 0)
            {
                Prop.SetA(double.Parse(initial_param_a.Text));
            }
            if (initial_param_b.Text.Length > 0)
            {
                Prop.SetB(double.Parse(initial_param_b.Text));
            }


            PlotInitFunc();
            
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

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
