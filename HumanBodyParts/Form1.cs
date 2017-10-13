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
            Pen receiptPen = new Pen(Color.Black, 10);
            Font tittleFont = new Font("Courier New", 12, FontStyle.Bold);
            Font writingFont = new Font("Courier New", 8, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush receiptBrush = new SolidBrush(Color.Black);

            receiptGraphics.DrawRectangle(receiptPen, 200, 20, 250, 250);
            receiptGraphics.FillRectangle(receiptBrush, 200, 20, 250, 250);
            receiptGraphics.TranslateTransform(200, 30);
            receiptGraphics.DrawString("Medical Sale Reciept", tittleFont, whiteBrush, new Rectangle());
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("Order # 4E + 256", writingFont, whiteBrush, new Rectangle());
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("November 11, 2999", writingFont, whiteBrush, new Rectangle());
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("Heart:   " + heart +"@" + heart*HEART, writingFont, whiteBrush, new Rectangle());
            receiptGraphics.DrawRectangle(receiptPen, 0, 140, 250, 40);
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("Leg:   " + leg + " @ " + leg*LEG, writingFont, whiteBrush, new Rectangle());
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("Eye:   " + eye + " @ " + eye*EYE,writingFont, whiteBrush, new Rectangle());




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
