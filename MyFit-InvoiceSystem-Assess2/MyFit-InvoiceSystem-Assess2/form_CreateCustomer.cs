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
    public partial class form_CreateCustomer : Form
    {
        public form_CreateCustomer()
        {
            InitializeComponent();
        }

        Customer[] customerArray = new Customer[10];

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_CreateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btn_StartAgain_Click(object sender, EventArgs e)
        {
            txt_CusNum.Text = String.Empty;
            txt_CusName.Text = String.Empty;
            txt_PhoneNum.Text = String.Empty;
            txt_Address1.Text = String.Empty;
            txt_Address2.Text = String.Empty;
            txt_Suburb.Text = String.Empty;
            txt_City.Text = String.Empty;
            txt_Postcode.Text = String.Empty;
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_MainMenu SwitchToMain = new form_MainMenu();
            SwitchToMain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customerInfo = new Customer();

            //taking in all of the values from the form's textboxes
            customerInfo.setCustomerIDNumber = Int32.Parse(txt_CusNum.Text);
            customerInfo.setCustomerName = txt_CusName.Text;
            customerInfo.setCustomerPhoneNum = Int32.Parse(txt_PhoneNum.Text);
            customerInfo.setCustomerAddress1 = txt_Address1.Text;
            customerInfo.setCustomerAddress2 = txt_Address2.Text;
            customerInfo.setCustomerSuburb = txt_Suburb.Text;
            customerInfo.setCustomerCity = txt_City.Text;
            customerInfo.setCustomerPostcode = Int32.Parse(txt_Postcode.Text);

            //putting the new object into our array
            customerArray[0] = customerInfo;

            //clearing out the textboxes
            txt_CusNum.Text = String.Empty;
            txt_CusName.Text = String.Empty;
            txt_PhoneNum.Text = String.Empty;
            txt_Address1.Text = String.Empty;
            txt_Address2.Text = String.Empty;
            txt_Suburb.Text = String.Empty;
            txt_City.Text = String.Empty;
            txt_Postcode.Text = String.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_CompName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_PrintCustomerInfo_Click(object sender, EventArgs e)
        {
            //Making a new string called outputString
            string outputString;

            //building outputString as this big, multiline monster
            outputString = "CUSTOMER ID NUMBER: " + customerArray[0].setCustomerIDNumber + "\n\n";
            outputString += "CUSTOMER NAME: " + customerArray[0].setCustomerName + "\n\n";
            outputString += "CUSTOMER PHONE NUMBER: " + customerArray[0].setCustomerPhoneNum + "\n\n";
            outputString += "CUSTOMER ADDRESS (LINE 1): " + customerArray[0].setCustomerAddress1 + "\n\n";
            outputString += "CUSTOMER ADDRESS (LINE 2): " + customerArray[0].setCustomerAddress2 + "\n\n";
            outputString += "CUSTOMER SUBURB: " + customerArray[0].setCustomerSuburb + "\n\n";
            outputString += "CUSTOMER CITY: " + customerArray[0].setCustomerCity + "\n\n";
            outputString += "CUSTOMER POSTCODE: " + customerArray[0].setCustomerPostcode + "\n\n";

            //displaying outputString in a messageBox
            MessageBox.Show(outputString);
        }
    }
}
