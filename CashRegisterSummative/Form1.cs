using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegisterSummative
{
    public partial class Form1 : Form
    {
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
            reciptButton.Visible = false;
            orderButton.Visible = true;
            reciptLabel.Visible = false;
            Graphics fG = this.CreateGraphics();
            SolidBrush reciptBrush = new SolidBrush(Color.Black);
            SolidBrush fillBrush = new SolidBrush(Color.Snow);
            Font reciptFont = new Font("Consolas", 8, FontStyle.Regular);

            fG.FillRectangle(fillBrush, 231, 9, 160, 232);
            fG.DrawString("Issa Burger",reciptFont, reciptBrush, 265, 13);
            fG.DrawString("Burgers", reciptFont, reciptBrush, 236, 40);
            fG.DrawString("Fries", reciptFont, reciptBrush, 236, 50);
            fG.DrawString("Drinks", reciptFont, reciptBrush, 236, 60);

            burgerCosts.Text = burgerDue.ToString("C");
            fryCost.Text = fryDue.ToString("C");
            drinkCost.Text = drinkDue.ToString("C");
            burgerNumber.Text = "x" + burgerOrder;
            fryNumber.Text = "x" + fryOrder;
            drinkNumber.Text = "x" + drinkOrder;

        }

        private void orderButton_Click(object sender, EventArgs e)
        {


            reciptButton.Visible = true;
            orderButton.Visible = false;
            reciptLabel.Visible = true;
            costOutput.Text = "Calculate Cost First";
            changeOutput.Text = "Calculate Change First";
            burgerInput.Text = String.Empty;
            fryInput.Text = String.Empty;
            drinkInput.Text = String.Empty;
            recievedInput.Text = String.Empty;
            

        }
    }
}
