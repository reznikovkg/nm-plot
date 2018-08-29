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

        public Form2(List<double> _er1, List<double> _er2)
        {
            InitializeComponent();

            
            this.errorSpline = _er1;
            this.errorPolynom = _er2;
            
            String erpol = "";
            String erspl = "";

            for (int t = 0; t<this.errorPolynom.Count;t++)
            {
                erspl += "\n";
                erspl += this.errorSpline[t];

                erpol += "\n";
                erpol += this.errorPolynom[t];
            }

            textBox2.Text = erpol;
            textBox1.Text = erspl;



            
            textBox3.Text = errorPolynom.Max().ToString();
            textBox4.Text = errorPolynom.Sum().ToString();




            textBox6.Text = errorSpline.Max().ToString();
            textBox5.Text = errorSpline.Sum().ToString();


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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
