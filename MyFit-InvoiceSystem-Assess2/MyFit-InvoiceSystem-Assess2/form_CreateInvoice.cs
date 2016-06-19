using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFit_InvoiceSystem_Assess2
{
    public partial class form_CreateInvoice : Form
    {
        public form_CreateInvoice()
        {
            InitializeComponent();
        }

        Invoice[] invoiceArray = new Invoice[10];

        private void button1_Click(object sender, EventArgs e)
        {
            //declaring and initializing TotalCost
            double TotalCost;
            TotalCost = 0;
            
            //declaring component variables
            int quantity;
            double costPerItem;
            //and setting up there data
            quantity = Int32.Parse(domUpDown_Quantity.Text);
            costPerItem = Int32.Parse(txt_CostPerItem.Text);

            //calculating TotalCost
            TotalCost = quantity * costPerItem;

            txt_TotalCost.Text = TotalCost.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //declaring a new Invoice object
            Invoice invoice1 = new Invoice();

            //setting that new object's data
            invoice1.setCustomerIDNum = Int32.Parse(txt_CusNum.Text);
            invoice1.setCustomerName = txt_CusName.Text;
            invoice1.setCustomerAddress = txt_CusAddress.Text;
            invoice1.setProductType = txt_ProdType.Text;
            invoice1.setProductQuantity = Int32.Parse(domUpDown_Quantity.Text);
            invoice1.setProductCostPerItem = Int32.Parse(txt_CostPerItem.Text);
            invoice1.setProductTotalCost = invoice1.setProductQuantity * invoice1.setProductCostPerItem;

            //saving that object into the 0 slot on the array
            invoice1.sendToDB(invoice1);

            //emptying out all of the textboxes
            txt_CusNum.Text = String.Empty;
            txt_CusName.Text = String.Empty;
            txt_CusAddress.Text = String.Empty;
            txt_ProdType.Text = String.Empty;
            domUpDown_Quantity.Text = "0";
            txt_CostPerItem.Text = String.Empty;
            txt_TotalCost.Text = String.Empty;
        }

        private void btn_StartAgain_Click(object sender, EventArgs e)
        {
            txt_CusNum.Text = String.Empty;
            txt_CusName.Text = String.Empty;
            txt_CusAddress.Text = String.Empty;
            txt_ProdType.Text = String.Empty;
            domUpDown_Quantity.Text = "0";
            txt_CostPerItem.Text = String.Empty;
            txt_TotalCost.Text = String.Empty;
        }

        private void btn_PrintInvoiceArray_Click(object sender, EventArgs e)
        {
            //string output;

            //output = "CUSTOMER ID: " + invoiceArray[0].setCustomerIDNum + "\n\n";
            //output += "CUSTOMER NAME: " + invoiceArray[0].setCustomerName + "\n\n";
            //output += "CUSTOMER ADDRESS: " + invoiceArray[0].setCustomerAddress + "\n\n";
            //output += "TYPE OF PRODUCT: " + invoiceArray[0].setProductType + "\n\n";
            //output += "QUANTITY OF PRODUCT: " + invoiceArray[0].setProductQuantity + "\n\n";
            //output += "COST PER ITEM: " + invoiceArray[0].setProductCostPerItem + "\n\n";
            //output += "TOTAL COST OF ORDER: " + invoiceArray[0].setProductTotalCost + "\n\n";

            //MessageBox.Show(output);

            //creating object of form_ViewInvoices
            form_ViewInvoices openFrom = new form_ViewInvoices();

            //opening the form
            openFrom.Show();
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            form_MainMenu switchBackToMain = new form_MainMenu();
            switchBackToMain.Show();
        }
    }
}
