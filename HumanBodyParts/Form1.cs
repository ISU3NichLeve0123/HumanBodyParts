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
        double cash;
        double change;
        public medicalSale()
        {

            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try { 
            eye = Convert.ToInt16(eyeTextBox.Text);
            leg = Convert.ToInt16(legTextBox.Text);
            heart = Convert.ToInt16(heartTextBox.Text);
            subtotal = eye * EYE + leg * LEG + heart * HEART;
            subTotalLabel.Visible = true;
            subTotalLabel.Text = "SubTotal:            " + subtotal.ToString("C");
            tax = subtotal * TAX;
            taxLabel.Visible = true;
            taxLabel.Text = "     Tax:                 " + tax.ToString("C");
            totalLabel.Visible = true;
            total = tax + subtotal;
            totalLabel.Text = "   Total:               " + total.ToString("C");
            cashLabel.Visible = true;
            cashTextBox.Visible = true;
            changeButton.Visible = true;
            changeLabel.Visible = true;
            }
            catch
            {
                taxLabel.Text = "ERROR:INVAILD INPUT";
            }
        }

        private void printReciptButton_Click(object sender, EventArgs e)
        {
            Graphics receiptGraphics = this.CreateGraphics();
            Pen reciptPen = new Pen(Color.Black, 10);
            SolidBrush recpitBrush = new SolidBrush(Color.White);
            receiptGraphics.DrawRectangle(reciptPen, 200, 20 ,250, 250);

            receiptGraphics.FillRectangle( recpitBrush , 200, 20, 250, 250);
            newOrderButon.Visible = true;
        }

        private void newOrderButon_Click(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                cash = Convert.ToInt16(cashTextBox.Text);
                change = cash - total;
                changeLabel.Text = "Change:               " + change.ToString("C");
                printReciptButton.Visible = true;
            }
            catch
            {
                taxLabel.Text = "ERROR:INVALID ACTION";
            }
        }
    }
}
