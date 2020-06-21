using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormClass
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        // declare an instance for our above Class "calculation"
        Calculation cal = new Calculation();


        private void btnVolume_Click(object sender, EventArgs e)
        {
            try
            {
                cal.SetBoxCalc(int.Parse(textLength.Text), int.Parse(textBreadth.Text), int.Parse(textHeight.Text));
                double i = cal.GetVol();
                textResult.Text = i.ToString();
            }

            catch(Exception ex)
            {
                MessageBox.Show("error in volume button event ..." + ex);
            }

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                cal.SetBoxCalc(int.Parse(textLength.Text), int.Parse(textBreadth.Text), int.Parse(textHeight.Text));
                double i = cal.GetArea();
                textResult.Text = i.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error in volume button event ..." + ex);
            }


        }
    }

    partial class Calculation
    {
        // define variables
        double Length;
        double Breadth;
        double Height;


        // method for defining the variables
        public void SetBoxCalc(double len, double bre, double hei)
        {
            Length = len;
            Breadth = bre;
            Height = hei;
        }

        // get the volume of box
        public double GetVol()
        {
            return Length * Breadth * Height;
        }

        // get the area of box
        public double GetArea()
        {
            double side1;
            double side2;
            double top;

            side1 = Length * Height * 2;
            side2 = Breadth * Height * 2;
            top = Length * Breadth * 2;

            return side1 + side2 + top;

        }


    }


}
