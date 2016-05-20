using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFit_InvoiceSystem_Assess2
{
    class Customer
    {
        private int customerIDNumber;
        private String customerName;
        private int customerPhoneNum;
        private String customerAddress1;
        private String customerAddress2;
        private String customerSuburb;
        private String customerCity;
        private int customerPostcode;
        private String customerState;
    
        public Customer()
        {
            customerIDNumber = 0;
            customerName = "No customer name set";
            customerPhoneNum = 0;
            customerAddress1 = "No customer address line 1 set";
            customerAddress2 = "No customer address line 2 set";
            customerSuburb = "No customer suburb set";
            customerCity = "No customer city set";
            customerPostcode = 0;
            customerState = "No customer state set";
        }

        public int setCustomerIDNumber
        {
            set { customerIDNumber = value; }
            get { return customerIDNumber; }
        }

        public String setCustomerName
        {
            set { customerName = value; }
            get { return customerName; }
        }

        public int setCustomerPhoneNum
        {
            set { customerPhoneNum = value; }
            get { return customerPhoneNum; }
        }

        public String setCustomerAddress1
        {
            set { customerAddress1 = value; }
            get { return customerAddress1; }
        }

        public String setCustomerAddress2
        {
            set { customerAddress2 = value; }
            get { return customerAddress2; }
        }

        public String setCustomerSuburb
        {
            set { customerSuburb = value; }
            get { return customerSuburb; }
        }

        public String setCustomerCity
        {
            set { customerCity = value; }
            get { return customerSuburb; }
        }

        public int setCustomerPostcode
        {
            set { customerPostcode = value; }
            get { return customerPostcode; }
        }

        public String setCustomerState
        {
            set { customerState = value; }
            get { return customerState; }
        }
    }

}
