// Nicholas Levesque Oct 10,2017, this programs shows an understanding of variables, simple math statements, and graphics.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HumanBodyParts
{
    public partial class medicalSale : Form
    {
        public medicalSale()
        {
            //Constants
            const double TAX = 0.13;
            const double HEART = 12000.89;
            const double LEG = 999.99;
            const double EYE = 450.97;


            //Variables
            string eye;
            string leg;
            string heart;
            double subtotal;
            double tax;
            double Total;
            double cash;
            double change;
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            eye = Convert.ToInt16(eyeTextBox.Text);
            subTotalLabel = eye;

        }

        private void printReciptButton_Click(object sender, EventArgs e)
        {

        }

        private void newOrderButon_Click(object sender, EventArgs e)
        {

        }
    }
}
