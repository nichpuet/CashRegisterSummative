﻿namespace CashRegisterSummative
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.fryInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.fryLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.costOutput = new System.Windows.Forms.Label();
            this.recievedInput = new System.Windows.Forms.TextBox();
            this.recievedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.Label();
            this.reciptButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.reciptLabel = new System.Windows.Forms.Label();
            this.burgerCosts = new System.Windows.Forms.Label();
            this.fryCost = new System.Windows.Forms.Label();
            this.drinkCost = new System.Windows.Forms.Label();
            this.burgerNumber = new System.Windows.Forms.Label();
            this.fryNumber = new System.Windows.Forms.Label();
            this.drinkNumber = new System.Windows.Forms.Label();
            this.beforeTaxOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerInput
            // 
            this.burgerInput.Location = new System.Drawing.Point(72, 24);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(100, 20);
            this.burgerInput.TabIndex = 0;
            this.burgerInput.Text = "0";
            // 
            // fryInput
            // 
            this.fryInput.Location = new System.Drawing.Point(72, 51);
            this.fryInput.Name = "fryInput";
            this.fryInput.Size = new System.Drawing.Size(100, 20);
            this.fryInput.TabIndex = 1;
            this.fryInput.Text = "0";
            // 
            // drinkInput
            // 
            this.drinkInput.Location = new System.Drawing.Point(72, 77);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(100, 20);
            this.drinkInput.TabIndex = 2;
            this.drinkInput.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(72, 104);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 25);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Location = new System.Drawing.Point(-2, 27);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(68, 13);
            this.burgerLabel.TabIndex = 4;
            this.burgerLabel.Text = "# of Burgers:";
            // 
            // fryLabel
            // 
            this.fryLabel.AutoSize = true;
            this.fryLabel.Location = new System.Drawing.Point(12, 54);
            this.fryLabel.Name = "fryLabel";
            this.fryLabel.Size = new System.Drawing.Size(54, 13);
            this.fryLabel.TabIndex = 5;
            this.fryLabel.Text = "# of Fries:";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Location = new System.Drawing.Point(6, 80);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(62, 13);
            this.drinkLabel.TabIndex = 6;
            this.drinkLabel.Text = "# of Drinks:";
            // 
            // costOutput
            // 
            this.costOutput.AutoSize = true;
            this.costOutput.Location = new System.Drawing.Point(72, 136);
            this.costOutput.Name = "costOutput";
            this.costOutput.Size = new System.Drawing.Size(97, 13);
            this.costOutput.TabIndex = 7;
            this.costOutput.Text = "Calculate Cost First";
            // 
            // recievedInput
            // 
            this.recievedInput.Location = new System.Drawing.Point(99, 185);
            this.recievedInput.Name = "recievedInput";
            this.recievedInput.Size = new System.Drawing.Size(100, 20);
            this.recievedInput.TabIndex = 9;
            this.recievedInput.Text = "0";
            // 
            // recievedLabel
            // 
            this.recievedLabel.AutoSize = true;
            this.recievedLabel.Location = new System.Drawing.Point(-2, 188);
            this.recievedLabel.Name = "recievedLabel";
            this.recievedLabel.Size = new System.Drawing.Size(95, 13);
            this.recievedLabel.TabIndex = 10;
            this.recievedLabel.Text = "Amount Recieved:";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(72, 211);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(97, 36);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Location = new System.Drawing.Point(69, 250);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(113, 13);
            this.changeOutput.TabIndex = 12;
            this.changeOutput.Text = "Calculate Change First";
            // 
            // reciptButton
            // 
            this.reciptButton.Location = new System.Drawing.Point(229, 245);
            this.reciptButton.Name = "reciptButton";
            this.reciptButton.Size = new System.Drawing.Size(143, 23);
            this.reciptButton.TabIndex = 13;
            this.reciptButton.Text = "Print Recipt";
            this.reciptButton.UseVisualStyleBackColor = true;
            this.reciptButton.Click += new System.EventHandler(this.reciptButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(229, 245);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(143, 23);
            this.orderButton.TabIndex = 14;
            this.orderButton.Text = "New Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Visible = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // reciptLabel
            // 
            this.reciptLabel.BackColor = System.Drawing.Color.Snow;
            this.reciptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reciptLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.reciptLabel.Location = new System.Drawing.Point(229, 9);
            this.reciptLabel.Name = "reciptLabel";
            this.reciptLabel.Size = new System.Drawing.Size(156, 233);
            this.reciptLabel.TabIndex = 8;
            this.reciptLabel.Text = "Recipt";
            this.reciptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // burgerCosts
            // 
            this.burgerCosts.AutoSize = true;
            this.burgerCosts.BackColor = System.Drawing.Color.Snow;
            this.burgerCosts.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerCosts.Location = new System.Drawing.Point(329, 38);
            this.burgerCosts.Name = "burgerCosts";
            this.burgerCosts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.burgerCosts.Size = new System.Drawing.Size(0, 13);
            this.burgerCosts.TabIndex = 15;
            // 
            // fryCost
            // 
            this.fryCost.AutoSize = true;
            this.fryCost.BackColor = System.Drawing.Color.Snow;
            this.fryCost.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryCost.Location = new System.Drawing.Point(329, 51);
            this.fryCost.Name = "fryCost";
            this.fryCost.Size = new System.Drawing.Size(0, 13);
            this.fryCost.TabIndex = 16;
            // 
            // drinkCost
            // 
            this.drinkCost.AutoSize = true;
            this.drinkCost.BackColor = System.Drawing.Color.Snow;
            this.drinkCost.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkCost.Location = new System.Drawing.Point(329, 64);
            this.drinkCost.Name = "drinkCost";
            this.drinkCost.Size = new System.Drawing.Size(0, 13);
            this.drinkCost.TabIndex = 17;
            // 
            // burgerNumber
            // 
            this.burgerNumber.AutoSize = true;
            this.burgerNumber.BackColor = System.Drawing.Color.Snow;
            this.burgerNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerNumber.Location = new System.Drawing.Point(289, 38);
            this.burgerNumber.Name = "burgerNumber";
            this.burgerNumber.Size = new System.Drawing.Size(7, 13);
            this.burgerNumber.TabIndex = 18;
            this.burgerNumber.Text = "\r\n";
            // 
            // fryNumber
            // 
            this.fryNumber.AutoSize = true;
            this.fryNumber.BackColor = System.Drawing.Color.Snow;
            this.fryNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryNumber.Location = new System.Drawing.Point(289, 51);
            this.fryNumber.Name = "fryNumber";
            this.fryNumber.Size = new System.Drawing.Size(0, 13);
            this.fryNumber.TabIndex = 19;
            // 
            // drinkNumber
            // 
            this.drinkNumber.AutoSize = true;
            this.drinkNumber.BackColor = System.Drawing.Color.Snow;
            this.drinkNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkNumber.Location = new System.Drawing.Point(289, 64);
            this.drinkNumber.Name = "drinkNumber";
            this.drinkNumber.Size = new System.Drawing.Size(0, 13);
            this.drinkNumber.TabIndex = 20;
            // 
            // beforeTaxOutput
            // 
            this.beforeTaxOutput.AutoSize = true;
            this.beforeTaxOutput.BackColor = System.Drawing.Color.Snow;
            this.beforeTaxOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beforeTaxOutput.Location = new System.Drawing.Point(337, 80);
            this.beforeTaxOutput.Name = "beforeTaxOutput";
            this.beforeTaxOutput.Size = new System.Drawing.Size(0, 13);
            this.beforeTaxOutput.TabIndex = 21;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.BackColor = System.Drawing.Color.Snow;
            this.taxOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(337, 93);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 13);
            this.taxOutput.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(384, 270);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.beforeTaxOutput);
            this.Controls.Add(this.drinkNumber);
            this.Controls.Add(this.fryNumber);
            this.Controls.Add(this.burgerNumber);
            this.Controls.Add(this.drinkCost);
            this.Controls.Add(this.fryCost);
            this.Controls.Add(this.burgerCosts);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.reciptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.recievedLabel);
            this.Controls.Add(this.recievedInput);
            this.Controls.Add(this.reciptLabel);
            this.Controls.Add(this.costOutput);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.fryLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.fryInput);
            this.Controls.Add(this.burgerInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Issa Burger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.TextBox fryInput;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label fryLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Label costOutput;
        private System.Windows.Forms.TextBox recievedInput;
        private System.Windows.Forms.Label recievedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button reciptButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label reciptLabel;
        private System.Windows.Forms.Label burgerCosts;
        private System.Windows.Forms.Label fryCost;
        private System.Windows.Forms.Label drinkCost;
        private System.Windows.Forms.Label burgerNumber;
        private System.Windows.Forms.Label fryNumber;
        private System.Windows.Forms.Label drinkNumber;
        private System.Windows.Forms.Label beforeTaxOutput;
        private System.Windows.Forms.Label taxOutput;
    }
}

