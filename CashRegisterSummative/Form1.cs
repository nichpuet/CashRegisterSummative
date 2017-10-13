// Nick Puetz | Cash Register Summative | 11/10/17
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

namespace CashRegisterSummative
{
    public partial class Form1 : Form
    {
        // declares constants and different changing variables for global use
        const double TAX = 1.13;
        const double BURGER_PRICE = 2.49;
        const double FRY_PRICE = 1.89;
        const double DRINK_PRICE = 0.99;
        double preTaxCost = 0;
        double taxCost = 0;
        double afterTaxCost = 0;
        double custBill = 0;
        double custChange = 0;
        double burgerDue;
        double fryDue;
        double drinkDue;
        int burgerOrder;
        int fryOrder;
        int drinkOrder;


        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //takes the values in the text boxes and uses them to calculate the cost of the meal at various points.
            // Also uses try and catch to make sure the values entered are valid.
            try
            {
                burgerOrder = Convert.ToInt16(burgerInput.Text);
                fryOrder = Convert.ToInt16(fryInput.Text);
                drinkOrder = Convert.ToInt16(drinkInput.Text);

                burgerDue = burgerOrder * BURGER_PRICE;
                fryDue = fryOrder * FRY_PRICE;
                drinkDue = drinkOrder * DRINK_PRICE;

                preTaxCost = burgerDue + fryDue + drinkDue;
                taxCost = preTaxCost * TAX - preTaxCost;
                afterTaxCost = preTaxCost * TAX;

                costOutput.Text = "Cost Before Tax: " + preTaxCost.ToString("C") + "\nTax Cost: " + taxCost.ToString("C") + "\nTotal Cost: " + afterTaxCost.ToString("C");
            }
            catch
            {
                costOutput.Text = "Please enter valid values into the fields";
            }

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            // Takes the inputs for change and calculates the customer change as well as the bills tendered.
            //Again uses try and catch to validate inputs
            try
            {
                custBill = Convert.ToDouble(recievedInput.Text);
                custChange = custBill - afterTaxCost;


                changeOutput.Text = "Change Due: " + custChange.ToString("C");
            }
            catch
            {
                changeOutput.Text = "Input Valid Amount";
            }
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            //Makes the button to print recipt invisible and make the new order button visible.
            // also declares all the different fonts, graphics, sounds, and random numbers to use in the recipt.
            reciptButton.Visible = false;
            orderButton.Visible = true;
            reciptLabel.Visible = false;
            Graphics fG = this.CreateGraphics();
            SolidBrush reciptBrush = new SolidBrush(Color.Black);
            SolidBrush fillBrush = new SolidBrush(Color.Snow);
            Font reciptFont = new Font("Consolas", 8, FontStyle.Regular);
            Random rnd = new Random();
            int randOrder = rnd.Next(1000, 9999);
            SoundPlayer reciptPlayer = new SoundPlayer(Properties.Resources.reciptSound);
            int time = 1000;

            //prints the recipt background and the text with a second delay between with a sound with each.
            fG.FillRectangle(fillBrush, 231, 9, 160, 232);
            reciptPlayer.Play();
            fG.DrawString("Issa Burger", reciptFont, reciptBrush, 265, 13);
            Thread.Sleep(time);
            reciptPlayer.Play();
            fG.DrawString("Burgers    " + "x" + burgerOrder + "    " + burgerDue.ToString("C"), reciptFont, reciptBrush, 236, 38);
            Thread.Sleep(time);
            reciptPlayer.Play();
            fG.DrawString("Fries      " + "x" + fryOrder + "    " + drinkDue.ToString("C"), reciptFont, reciptBrush, 236, 50);
            Thread.Sleep(time);
            reciptPlayer.Play();
            fG.DrawString("Drinks     " + "x" + drinkOrder + "    " + drinkDue.ToString("C"), reciptFont, reciptBrush, 236, 62);
            Thread.Sleep(time);
            reciptPlayer.Play();
            fG.DrawString("Total Before Tax: " + preTaxCost.ToString("C"), reciptFont, reciptBrush, 236, 80);
            Thread.Sleep(time);
            reciptPlayer.Play();
            fG.DrawString("Tax Cost:         " + taxCost.ToString("C"), reciptFont, reciptBrush, 236, 92);
            Thread.Sleep(time);
            reciptPlayer.Play();
            fG.DrawString("Final Total:      " + afterTaxCost.ToString("C"), reciptFont, reciptBrush, 236, 104);
            Thread.Sleep(time);
            reciptPlayer.Play();
            fG.DrawString("Change Tendered: " + custBill.ToString("C"), reciptFont, reciptBrush, 236, 122);
            Thread.Sleep(time);
            reciptPlayer.Play();
            fG.DrawString("Change Due:      " + custChange.ToString("C"), reciptFont, reciptBrush, 236, 140);
            Thread.Sleep(time);
            reciptPlayer.Play();
            fG.DrawString("Order #" + randOrder, reciptFont, reciptBrush, 265, 164);
            Thread.Sleep(time);
            reciptPlayer.Play();
               
            
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            //Clears the input boxes and sets text and buttons back to their original states
            // Also sets variables like the number of items and such to 0
            reciptButton.Visible = true;
            orderButton.Visible = false;
            reciptLabel.Visible = true;
            costOutput.Text = "Calculate Cost First";
            changeOutput.Text = "Calculate Change First";
            burgerInput.Text = String.Empty;
            fryInput.Text = String.Empty;
            drinkInput.Text = String.Empty;
            recievedInput.Text = String.Empty;

            preTaxCost = 0;
            taxCost = 0;
            afterTaxCost = 0;
            custBill = 0;
            custChange = 0;
            burgerDue = 0;
            fryDue = 0;
            drinkDue = 0;
            burgerOrder = 0;
            fryOrder = 0;
            drinkOrder = 0;
        }
    }
}
