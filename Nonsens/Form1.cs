using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Nonsens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;
            double c = (double)numericUpDown3.Value;

            try
            {
                if (a + b <= c || a + c <= b || b + c <= a) throw new ArgumentException();

                textBox1.Text = Maths.Circumference(a, b, c).ToString();
                textBox2.Text = Maths.Area(a, b, c).ToString();

                errlbl.Visible = false;
            }
            catch(ArgumentException f)
            {
                errlbl.Visible = true;
            }
        }
    }

    public class Maths
    {
        public static double Circumference (double a, double b, double c)
        {
            return a + b + c;
        }

        public static double Area (double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
}
