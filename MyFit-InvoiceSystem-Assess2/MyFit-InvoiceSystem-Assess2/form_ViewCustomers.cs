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
                MySqlDataAdapter pullDown = new MySqlDataAdapter("Select * From `customers`", connectionString);

                //putting the data into the dataset
                pullDown.Fill(customerLog);

                for (int count = 0; count <= customerLog.Tables[0].Rows.Count - 1; count++)
                {
                    this.dataGridView1.Rows.Add
                    (
                      customerLog.Tables[0].Rows[count].ItemArray[0].ToString(),
                      customerLog.Tables[0].Rows[count].ItemArray[1].ToString(),
                      customerLog.Tables[0].Rows[count].ItemArray[2].ToString(),
                      customerLog.Tables[0].Rows[count].ItemArray[3].ToString(),
                      customerLog.Tables[0].Rows[count].ItemArray[4].ToString(),
                      customerLog.Tables[0].Rows[count].ItemArray[5].ToString(),
                      customerLog.Tables[0].Rows[count].ItemArray[6].ToString(),
                      customerLog.Tables[0].Rows[count].ItemArray[7].ToString()
                    );
                }
            }

            catch (MySqlException error)
            {
                string errorMsg;
                errorMsg = "Connection Unsuccessful." + "\n \n";
                errorMsg += error.Message;

                MessageBox.Show(errorMsg);
            }
        }
    }
}
