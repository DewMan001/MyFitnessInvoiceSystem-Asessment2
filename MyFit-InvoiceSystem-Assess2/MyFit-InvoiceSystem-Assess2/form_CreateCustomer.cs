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
            customerInfo.setCustomerState = cboBox_State.Text;

            //sending info up to the database
            customerInfo.sendToDB(customerInfo);

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
            //creating a new object of the view customers form
            form_ViewCustomers openForm = new form_ViewCustomers();
            
            //opening the form up.
            openForm.Show();
            
        }
    }
}
