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
            txt_CompName.Text = String.Empty;
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
    }
}
