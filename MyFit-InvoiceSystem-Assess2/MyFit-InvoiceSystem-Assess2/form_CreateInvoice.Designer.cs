namespace MyFit_InvoiceSystem_Assess2
{
    partial class form_CreateInvoice
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
            this.txt_CusNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TotalCost = new System.Windows.Forms.TextBox();
            this.txt_CostPerItem = new System.Windows.Forms.TextBox();
            this.txt_ProdType = new System.Windows.Forms.TextBox();
            this.txt_CusAddress = new System.Windows.Forms.TextBox();
            this.txt_CusName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.domUpDown_Quantity = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_StartAgain = new System.Windows.Forms.Button();
            this.btn_SaveInvoice = new System.Windows.Forms.Button();
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.btn_PrintInvoiceArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_CusNum
            // 
            this.txt_CusNum.Location = new System.Drawing.Point(175, 42);
            this.txt_CusNum.Name = "txt_CusNum";
            this.txt_CusNum.Size = new System.Drawing.Size(181, 26);
            this.txt_CusNum.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Customer Number";
            // 
            // txt_TotalCost
            // 
            this.txt_TotalCost.Location = new System.Drawing.Point(175, 322);
            this.txt_TotalCost.Name = "txt_TotalCost";
            this.txt_TotalCost.Size = new System.Drawing.Size(181, 26);
            this.txt_TotalCost.TabIndex = 35;
            // 
            // txt_CostPerItem
            // 
            this.txt_CostPerItem.Location = new System.Drawing.Point(175, 276);
            this.txt_CostPerItem.Name = "txt_CostPerItem";
            this.txt_CostPerItem.Size = new System.Drawing.Size(181, 26);
            this.txt_CostPerItem.TabIndex = 33;
            // 
            // txt_ProdType
            // 
            this.txt_ProdType.Location = new System.Drawing.Point(175, 184);
            this.txt_ProdType.Name = "txt_ProdType";
            this.txt_ProdType.Size = new System.Drawing.Size(181, 26);
            this.txt_ProdType.TabIndex = 30;
            // 
            // txt_CusAddress
            // 
            this.txt_CusAddress.Location = new System.Drawing.Point(175, 138);
            this.txt_CusAddress.Name = "txt_CusAddress";
            this.txt_CusAddress.Size = new System.Drawing.Size(181, 26);
            this.txt_CusAddress.TabIndex = 28;
            // 
            // txt_CusName
            // 
            this.txt_CusName.Location = new System.Drawing.Point(175, 88);
            this.txt_CusName.Name = "txt_CusName";
            this.txt_CusName.Size = new System.Drawing.Size(181, 26);
            this.txt_CusName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Product Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cost Per Item";
            // 
            // domUpDown_Quantity
            // 
            this.domUpDown_Quantity.Items.Add("0");
            this.domUpDown_Quantity.Items.Add("1");
            this.domUpDown_Quantity.Items.Add("2");
            this.domUpDown_Quantity.Items.Add("3");
            this.domUpDown_Quantity.Items.Add("4");
            this.domUpDown_Quantity.Items.Add("5");
            this.domUpDown_Quantity.Items.Add("6");
            this.domUpDown_Quantity.Items.Add("7");
            this.domUpDown_Quantity.Items.Add("8");
            this.domUpDown_Quantity.Items.Add("9");
            this.domUpDown_Quantity.Items.Add("10");
            this.domUpDown_Quantity.Items.Add("11");
            this.domUpDown_Quantity.Items.Add("12");
            this.domUpDown_Quantity.Items.Add("13");
            this.domUpDown_Quantity.Items.Add("14");
            this.domUpDown_Quantity.Items.Add("15");
            this.domUpDown_Quantity.Items.Add("16");
            this.domUpDown_Quantity.Items.Add("17");
            this.domUpDown_Quantity.Items.Add("18");
            this.domUpDown_Quantity.Items.Add("19");
            this.domUpDown_Quantity.Items.Add("20");
            this.domUpDown_Quantity.Location = new System.Drawing.Point(175, 233);
            this.domUpDown_Quantity.Name = "domUpDown_Quantity";
            this.domUpDown_Quantity.Size = new System.Drawing.Size(72, 26);
            this.domUpDown_Quantity.TabIndex = 42;
            this.domUpDown_Quantity.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Total Cost";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(175, 354);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(181, 52);
            this.btn_Calculate.TabIndex = 44;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_StartAgain
            // 
            this.btn_StartAgain.Location = new System.Drawing.Point(482, 98);
            this.btn_StartAgain.Name = "btn_StartAgain";
            this.btn_StartAgain.Size = new System.Drawing.Size(155, 69);
            this.btn_StartAgain.TabIndex = 46;
            this.btn_StartAgain.Text = "Start Again";
            this.btn_StartAgain.UseVisualStyleBackColor = true;
            this.btn_StartAgain.Click += new System.EventHandler(this.btn_StartAgain_Click);
            // 
            // btn_SaveInvoice
            // 
            this.btn_SaveInvoice.Location = new System.Drawing.Point(482, 12);
            this.btn_SaveInvoice.Name = "btn_SaveInvoice";
            this.btn_SaveInvoice.Size = new System.Drawing.Size(155, 69);
            this.btn_SaveInvoice.TabIndex = 45;
            this.btn_SaveInvoice.Text = "Save this Invoice";
            this.btn_SaveInvoice.UseVisualStyleBackColor = true;
            this.btn_SaveInvoice.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.Location = new System.Drawing.Point(482, 444);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(155, 69);
            this.btn_MainMenu.TabIndex = 47;
            this.btn_MainMenu.Text = "Return to Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // btn_PrintInvoiceArray
            // 
            this.btn_PrintInvoiceArray.Location = new System.Drawing.Point(482, 184);
            this.btn_PrintInvoiceArray.Name = "btn_PrintInvoiceArray";
            this.btn_PrintInvoiceArray.Size = new System.Drawing.Size(155, 69);
            this.btn_PrintInvoiceArray.TabIndex = 48;
            this.btn_PrintInvoiceArray.Text = "Print out invoiceArray";
            this.btn_PrintInvoiceArray.UseVisualStyleBackColor = true;
            this.btn_PrintInvoiceArray.Click += new System.EventHandler(this.btn_PrintInvoiceArray_Click);
            // 
            // form_CreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 525);
            this.Controls.Add(this.btn_PrintInvoiceArray);
            this.Controls.Add(this.btn_StartAgain);
            this.Controls.Add(this.btn_SaveInvoice);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.domUpDown_Quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CusNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_TotalCost);
            this.Controls.Add(this.txt_CostPerItem);
            this.Controls.Add(this.txt_ProdType);
            this.Controls.Add(this.txt_CusAddress);
            this.Controls.Add(this.txt_CusName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "form_CreateInvoice";
            this.Text = "form_CreateInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CusNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TotalCost;
        private System.Windows.Forms.TextBox txt_CostPerItem;
        private System.Windows.Forms.TextBox txt_ProdType;
        private System.Windows.Forms.TextBox txt_CusAddress;
        private System.Windows.Forms.TextBox txt_CusName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown domUpDown_Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_StartAgain;
        private System.Windows.Forms.Button btn_SaveInvoice;
        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.Button btn_PrintInvoiceArray;


    }
}