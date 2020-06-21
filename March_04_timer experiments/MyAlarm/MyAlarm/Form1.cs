using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyAlarm
{
    public partial class Form1 : Form
    {
        int h2, m2, s2;
        int h3, m3, s3;
        String h1; // will store hours
        String m1; // will store minutes
        String s1; // will store seconds
        bool bbtnpr1=false, bbtnpr2=false, bbtnpr3=false;

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("value of s1 is : ", s1);
            MessageBox.Show("value of s3 is : " +s3);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            h1 = DateTime.Now.Hour.ToString();
            m1 = DateTime.Now.Minute.ToString();
            s1 = DateTime.Now.Second.ToString();
            txtBoxDispT.Text = "" + h1 + ":" + m1 + ":" + s1;

            // convert all string to int
            h3 = int.Parse(h1);
            m3 = int.Parse(m1);
            s3 = int.Parse(s1);

            if (bbtnpr1==true & bbtnpr2==true)
            {
                // when values are equal 
                if (h3 == h2)
                {
                    MessageBox.Show("Hour is reached");
                }

                if (m3 == m2)
                {
                    MessageBox.Show("minute is reached");
                }

                if (s3==s2)
                {
                    MessageBox.Show("second is reached");
                    Console.Beep(2200, 1000);
                }
            }

            // change h2,m2,s2 as string
            txtB2.Text = "Alarm set at h2 :" + h2.ToString() + "\r\nAlarm set at m2 :" + m2.ToString() +
                "\r\nAlarm set at s2 :" + s2.ToString() + "\r\n...The current time is : " + ("" + h1 + ":" + m1 + ":" + s1);
            //h2.ToString();
            
        }

        private void btnSetAlrm_Click(object sender, EventArgs e)
        {
            try
            {

                h2 = Convert.ToInt32(Math.Round(numHr.Value));
                m2 = Convert.ToInt32(Math.Round(numMin.Value));
                s2 = Convert.ToInt32(Math.Round(numSec.Value));
                Update();
                bbtnpr1 = true;
            }
            catch
            {
                MessageBox.Show("h2 : " + h2);
                MessageBox.Show("m2 : " + m2);
                MessageBox.Show("s2 : " + s2);
            }
        }

        private void btnStartAlarm_Click(object sender, EventArgs e)
        {
            if (h2 == 0 && m2 == 0 && s2 == 0)
            {
                MessageBox.Show("The alarm is not set !");
            }

            bbtnpr2 = true;
       }
    }
}
