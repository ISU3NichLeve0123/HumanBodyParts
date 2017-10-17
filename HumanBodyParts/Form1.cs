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
using System.Media;

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
        double subTotal;
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
            //Calculates the total price of the order
            try
            {
                eye = Convert.ToInt16(eyeTextBox.Text);
                leg = Convert.ToInt16(legTextBox.Text);
                heart = Convert.ToInt16(heartTextBox.Text);
                subTotal = eye * EYE + leg * LEG + heart * HEART;
                subTotalLabel.Visible = true;
                subTotalLabel.Text = "SubTotal:            " + subTotal.ToString("C");
                tax = subTotal * TAX;
                taxLabel.Visible = true;
                taxLabel.Text = "     Tax:                 " + tax.ToString("C");
                totalLabel.Visible = true;
                total = tax + subTotal;
                totalLabel.Text = "   Total:               " + total.ToString("C");
                cashLabel.Visible = true;
                cashTextBox.Visible = true;
                changeButton.Visible = true;
                changeLabel.Visible = true;
            }
            catch
            {
                errorLabel.Text = "ERROR:INVAILD INPUT";
            }
        }

        private void printReciptButton_Click(object sender, EventArgs e)
        {
            //Draws a recipet
            Graphics receiptGraphics = this.CreateGraphics();
            Pen receiptPen = new Pen(Color.Black, 10);
            Font tittleFont = new Font("Courier New", 12, FontStyle.Bold);
            Font writingFont = new Font("Courier New", 8, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush receiptBrush = new SolidBrush(Color.Black);
            double heartTotal = heart * HEART;
            double eyeTotal = eye * EYE;
            double legTotal = leg * LEG;

            SoundPlayer player = new SoundPlayer(Properties.Resources.printReciept);
            player.PlaySync();
            receiptGraphics.DrawRectangle(receiptPen, 200, 20, 250, 250);
            receiptGraphics.FillRectangle(receiptBrush, 200, 20, 250, 250);
            receiptGraphics.TranslateTransform(200, 30);
            receiptGraphics.DrawString("Medical Sale Reciept", tittleFont, whiteBrush, new Rectangle());
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("Order # 4E + 256", writingFont, whiteBrush, new Rectangle());
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("November 11, 2999", writingFont, whiteBrush, new Rectangle());
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("Heart:   " + heart + "@" + HEART + heartTotal.ToString("C"), writingFont, whiteBrush, new Rectangle());
            receiptGraphics.DrawRectangle(receiptPen, 0, 140, 250, 40);
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("Leg:   " + leg + " @ " + LEG + legTotal.ToString("C"), writingFont, whiteBrush, new Rectangle());
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("Eye:   " + eye + " @ " + EYE + " " + eyeTotal.ToString("C"), writingFont, whiteBrush, new Rectangle());
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("subTotal:   " + subTotal.ToString("C"), writingFont, whiteBrush, new Rectangle());
            receiptGraphics.TranslateTransform(0, 30);
            receiptGraphics.DrawString("Tax:   " + tax.ToString("C"), writingFont, whiteBrush, new Rectangle());
            receiptGraphics.TranslateTransform(0, 20);
            receiptGraphics.DrawString("Total:   " + total.ToString("C"), writingFont, whiteBrush, new Rectangle());
            Thread.Sleep(1000);
            player.PlaySync();
            newOrderButton.Visible = true;
        }

        private void newOrderButon_Click(object sender, EventArgs e)
        {
            //Clears all the labels and chnages the varaibles to 0, makes most things invisible and refersh's the page
            changeLabel.Text = "";
            totalLabel.Text = "";
            subTotalLabel.Text = "";
            taxLabel.Text = "";
            cashLabel.Text = "";
            cashTextBox.Text = "";
            eyeTextBox.Text = "";
            legTextBox.Text = "";
            heartTextBox.Text = "";

            eye = 0;
            leg = 0;
            heart = 0;
            subTotal = 0;
            tax = 0;
            total = 0;
            cash = 0;
            change = 0;

            subTotalLabel.Visible = false;
            taxLabel.Visible = false;
            totalLabel.Visible = false;
            cashLabel.Visible = false;
            cashTextBox.Visible = false;
            changeButton.Visible = false;
            changeLabel.Visible = false;
            newOrderButton.Visible = false;
            printReciptButton.Visible = false;
            this.Refresh();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //Calculates the  total change for the cash the user put's in
            try
            {
                cash = Convert.ToInt16(cashTextBox.Text);
                change = cash - total;
                changeLabel.Text = "Change:               " + change.ToString("C");
                printReciptButton.Visible = true;
            }
            catch
            {
                errorLabel.Text = "ERROR:INVALID ACTION";
            }
        }
    }
}
