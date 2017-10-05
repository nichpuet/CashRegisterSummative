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

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double burgerCost;
            double fryCost;
            double drinkCost;
            int burgerOrder;
            int fryOrder;
            int drinkOrder;
            try
            {
                burgerOrder = Convert.ToInt16(burgerInput.Text);
                fryOrder = Convert.ToInt16(fryInput.Text);
                drinkOrder = Convert.ToInt16(drinkInput.Text);

                burgerCost = burgerOrder * BURGER_PRICE;
                fryCost = fryOrder * FRY_PRICE;
                drinkCost = drinkOrder * DRINK_PRICE;

                preTaxCost = burgerCost + fryCost + drinkCost;
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
            double amountRecieved;
            double changeDue;
            try
            {
                amountRecieved = Convert.ToInt16(recievedInput.Text);
                changeDue = amountRecieved - afterTaxCost;

                changeOutput.Text = "Change Due: " + changeDue.ToString("C");
            }
            catch
            {
                changeOutput.Text = "Input Valid Amount";
            }
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
