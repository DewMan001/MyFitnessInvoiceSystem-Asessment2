using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyFit_InvoiceSystem_Assess2
{
    public partial class form_ViewCustomers : Form
    {
        public form_ViewCustomers()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            form_ViewCustomers closeForm = new form_ViewCustomers();

            closeForm.Close();
        }

        private void form_ViewCustomers_Load(object sender, EventArgs e)
        {
            //making a string variable
            string connectionString;
            //and putting the connection string into it
            connectionString = "server=223.27.22.124;user id=myFitAdmin;password=FrZ4^HHgQL6pHK8nhcSe;database=041402192_myfitness";

            //connecting the app into the server
            MySqlConnection pipeLine = new MySqlConnection(connectionString);

            //makikng a new data set
            DataSet customerLog = new DataSet();

            try
            {
                //opening up the connection
                pipeLine.Open();

                //grabbing all of the data from the database
                MySqlDataAdapter pullDown = new MySqlDataAdapter("Select * From `account`", connectionString);

                //
            }
        }
    }
}
