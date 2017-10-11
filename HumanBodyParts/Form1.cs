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
        //Constants
        const double TAX = 0.13;
        const double HEART = 12000.89;
        const double LEG = 999.99;
        const double EYE = 450.97;


        //Variables
        int eye;
        int leg;
        int heart;
        double subtotal;
        double tax;
        double total;
        int cash;
        double change;
        public medicalSale()
        {

            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            eye = Convert.ToInt16(eyeTextBox.Text);
            leg = Convert.ToInt16(legTextBox.Text);
            heart= Convert.ToInt16(heartTextBox.Text);
            subtotal = eye * EYE + leg * LEG + heart * HEART;
            subTotalLabel.Visible = true;
            subTotalLabel.Text = "SubTotal:            " + Convert.ToString(subtotal);
            tax = subtotal * TAX;
            taxLabel.Visible = true;
            taxLabel.Text = "     Tax:                 " + Convert.ToString(tax);
            totalLabel.Visible = true;
            total = tax + subtotal;
            totalLabel.Text = "   Total:               " + Convert.ToString(total);
            cashLabel.Visible = true;
            cashTextBox.Visible = true;
            changeButton.Visible = true;
            changeLabel.Visible = true;
        }

        private void printReciptButton_Click(object sender, EventArgs e)
        {

        }

        private void newOrderButon_Click(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            cash = Convert.ToInt16(cashTextBox.Text);
            change = cash - total;
            changeLabel.Text = "Change:               " + Convert.ToString(change);
        }
    }
}
