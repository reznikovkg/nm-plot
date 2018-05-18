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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 50);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-1, 20);
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
        }
        
        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Points.AddXY(13, 13);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Myf();
            IP Mycl = new IP();

            Mycl.SetA(14.3);
            chart1.Series[1].Points.AddXY(3, Mycl.GetA());
        }

        public void Myf()
        {

            for (int i = (int)Prop.GetA(); i < (int)Prop.GetB(); i += 1)
            {
                chart1.Series[0].Points.AddXY(i, Math.Cos(i));
            }
            for (int i = 0; i < 50; i += 3)
            {
                chart1.Series[1].Points.AddXY(i, Math.Sin(i));
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button_rebuild(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(15, 20);
        }
    }
}
