using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nmplot
{
    public partial class Form2 : Form
    {

        List<double> errorSpline;
        List<double> errorPolynom;


        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<double> _x, List<double> _y, List<double> _er1, List<double> _er2)
        {
            InitializeComponent();

            
            this.errorSpline = _er1;
            this.errorPolynom = _er2;

            String x = "";
            String erpol = "";
            String erspl = "";

            for (int t = 0; t<this.errorPolynom.Count;t++)
            {
                erspl += "\n";
                erspl += Math.Abs(this.errorSpline[t] - _y[t]);

                erpol += "\n";
                erpol += Math.Abs(this.errorPolynom[t] - _y[t]);
            }

            textBox2.Text = erpol;
            textBox1.Text = erspl;



            label2.Text = "Max error: " + errorPolynom.Max();
            label1.Text = "Max error: " + errorSpline.Max();

        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
