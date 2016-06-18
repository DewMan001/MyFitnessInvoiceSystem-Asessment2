using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        public void sendToDB(Customer information)
        {
            //making a string variable
            string connectionString;
            //and putting the connection string into it
            connectionString = "server=223.27.22.124;user id=myFitAdmin;password=FrZ4^HHgQL6pHK8nhcSe;database=041402192_myfitness";

            //connecting the app into the server
            MySqlConnection pipeLine = new MySqlConnection(connectionString);

            try
            {
                //a message that'll be filled with data
                //and then sent up to the server
                string messageGoUp;

                //collecting up all the information

                //collecting the ID number
                string cusNum;
                cusNum = "'" + information.customerIDNumber + "'";

                //collecting the customer's name
                string cusName;
                cusName = "'" + information.customerName + "'";

                //collecting the customer's contact number
                string cusPhone;
                cusPhone = "'" + information.customerPhoneNum + "'";

                //collecting the customer's address
                string cusAddress;
                cusAddress = "'" + information.customerAddress1 + " , " + information.customerAddress2 + "'";

                //collecting the customer's suburb
                string cusSuburb;
                cusSuburb = "'" + information.customerSuburb + "'";

                //collecting the customer's city
                string cusCity;
                cusCity = "'" + information.customerCity + "'";

                //collecting the customer's postcode
                string cusPostcode;
                cusPostcode = "'" + information.customerPostcode + "'";

                //collecting the customer's state
                string cusState;
                cusState = "'" + information.customerState + "'";

                //putting all of that information into
                //a string
                messageGoUp = "INSERT INTO `customers`(`CusNumber`, `CusName`, `CusPhoneNum`, `CusAddress`, `CusSuburb`, `CusCity`, `CusPostCode`, `CusState`) VALUES (" + cusNum + "," + cusName + "," + cusPhone + "," + cusAddress + "," + cusSuburb + "," + cusCity + "," + cusPostcode + "," + cusState + ")";
                //making another brief connection
                MySqlConnection consoleConnection = new MySqlConnection(connectionString);

                //so we can send our command up
                MySqlCommand saveToDB = new MySqlCommand(messageGoUp, consoleConnection);
                consoleConnection.Open();
                saveToDB.ExecuteNonQuery();
                consoleConnection.Close();

            }

            catch (MySqlException connectionError)
            {
                string errorMessage;

                errorMessage = "Connection Unsuccessful";
                errorMessage += "\n \n";
                errorMessage += connectionError.Message;

                MessageBox.Show(errorMessage);
            }
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
