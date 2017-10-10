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
            Random rnd = new Random();
            int randOrder = rnd.Next(1000, 9999);
            SoundPlayer reciptPlayer = new SoundPlayer(Properties.Resources.reciptSound);

            int flag = 0;

            for (int x = 1; x<= 10; x++)
            {
                if (flag == 0)
                {
                    fG.FillRectangle(fillBrush, 231, 9, 160, 232);
                    fG.DrawString("Issa Burger", reciptFont, reciptBrush, 265, 13);
                    flag++;
                    Thread.Sleep(1000);
                    reciptPlayer.Play();
                }
               if (flag == 1)
                {
                    fG.DrawString("Burgers    " + "x" + burgerOrder + "    " + burgerDue.ToString("C"), reciptFont, reciptBrush, 236, 38);
                    flag++;
                    Thread.Sleep(1000);
                    reciptPlayer.Play();
                }
               if(flag == 2)
                {
                    fG.DrawString("Fries      " + "x" + fryOrder + "    " + drinkDue.ToString("C"), reciptFont, reciptBrush, 236, 50);
                    flag++;
                    Thread.Sleep(1000);
                    reciptPlayer.Play();
                }
               if (flag == 3)
                {
                    fG.DrawString("Drinks     " + "x" + drinkOrder + "    " + drinkDue.ToString("C"), reciptFont, reciptBrush, 236, 62);
                    flag++;
                    Thread.Sleep(1000);
                    reciptPlayer.Play();
                }
               if(flag == 4)
                {
                    fG.DrawString("Total Before Tax: " + preTaxCost.ToString("C"), reciptFont, reciptBrush, 236, 80);
                    flag++;
                    Thread.Sleep(1000);
                    reciptPlayer.Play();
                }
               if (flag == 5)
                {
                    fG.DrawString("Tax Cost:         " + taxCost.ToString("C"), reciptFont, reciptBrush, 236, 92);
                    flag++;
                    Thread.Sleep(1000);
                    reciptPlayer.Play();
                }
               if (flag == 6)
                {
                    fG.DrawString("Final Total:      " + afterTaxCost.ToString("C"), reciptFont, reciptBrush, 236, 104);
                    flag++;
                    Thread.Sleep(1000);
                    reciptPlayer.Play();
                }
               if (flag == 7)
                {
                    fG.DrawString("Change Tendered: " + custBill.ToString("C"), reciptFont, reciptBrush, 236, 122);
                    flag++;
                    Thread.Sleep(1000);
                    reciptPlayer.Play();
                }
               if (flag == 8)
                {
                    fG.DrawString("Change Due:      " + custChange.ToString("C"), reciptFont, reciptBrush, 236, 140);
                    flag++;
                    Thread.Sleep(1000);
                    reciptPlayer.Play();
                }
               if (flag == 9)
                {
                    fG.DrawString("Order #" + randOrder, reciptFont, reciptBrush, 265, 164);
                    flag++;
                    Thread.Sleep(1000);
                    reciptPlayer.Play();
                }
            }
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
