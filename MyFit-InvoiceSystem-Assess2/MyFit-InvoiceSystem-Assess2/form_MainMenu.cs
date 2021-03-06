﻿using System;
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
    public partial class form_MainMenu : Form
    {
        public form_MainMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form_Login SwitchToLogin = new form_Login();
            SwitchToLogin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            form_CreateCustomer SwitchToCreateCustomer = new form_CreateCustomer();
            SwitchToCreateCustomer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form_CreateInvoice SwitchToCreateInvoice = new form_CreateInvoice();
            SwitchToCreateInvoice.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_ViewCustomers SwitchToViewCustomers = new form_ViewCustomers();

            SwitchToViewCustomers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //creating object of form_ViewInvoices
            form_ViewInvoices openFrom = new form_ViewInvoices();

            //opening the form
            openFrom.Show();
        }
    }
}
