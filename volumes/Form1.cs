using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volumes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {//read txt box values 
            double radious = double.Parse(textBox1.Text);
            double radious;

            // read radious value
            try
            {
                radious = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show(" error on input ");
                radious = 0.0;
            }

            // calculate volume
            double.volume = 4.0 / 3.0 * Math.PI * radious * radious * radious;

            //display volume 
            label1.text = "volume = "


        }
