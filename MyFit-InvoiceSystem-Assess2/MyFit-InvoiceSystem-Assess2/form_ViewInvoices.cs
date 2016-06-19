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
    public partial class form_ViewInvoices : Form
    {
        public form_ViewInvoices()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_ViewInvoices_Load(object sender, EventArgs e)
        {
            //making a string variable
            string connectionString;
            //and putting the connection string into it
            connectionString = "server=223.27.22.124;user id=myFitAdmin;password=FrZ4^HHgQL6pHK8nhcSe;database=041402192_myfitness";

            //connecting the app into the server
            MySqlConnection pipeLine = new MySqlConnection(connectionString);

            //making a new data set
            DataSet invoiceLog = new DataSet();

            try
            {
                //opening up the connection
                pipeLine.Open();

                //pulling down all of the information from the server
                MySqlDataAdapter pullDown = new MySqlDataAdapter("SELECT * FROM `invoice`", connectionString);

                pullDown.Fill(invoiceLog);

                for (int count = 0; count <= invoiceLog.Tables[0].Rows.Count - 1; count++)
                {
                    this.dataGridView1.Rows.Add
                        (
                            invoiceLog.Tables[0].Rows[count].ItemArray[0].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[1].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[2].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[3].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[4].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[5].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[6].ToString()
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //making a new string
            string connectionString;

            //putting the connection string into it
            connectionString = "server=223.27.22.124;user id=myFitAdmin;password=FrZ4^HHgQL6pHK8nhcSe;database=041402192_myfitness";

            //making a connection
            MySqlConnection pipeLine = new MySqlConnection(connectionString);

            //making a new dataset
            DataSet invoiceLog = new DataSet();

            try
            {
                //clearing out the rows in the data grid view
                this.dataGridView1.Rows.Clear();

                //opening up the connection
                pipeLine.Open();

                 //pulling down all of the information from the server
                MySqlDataAdapter pullDown = new MySqlDataAdapter("SELECT * FROM `invoice`", connectionString);

                pullDown.Fill(invoiceLog);

                for (int count = 0; count <= invoiceLog.Tables[0].Rows.Count - 1; count++)
                {
                    this.dataGridView1.Rows.Add
                        (
                            invoiceLog.Tables[0].Rows[count].ItemArray[0].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[1].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[2].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[3].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[4].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[5].ToString(),
                            invoiceLog.Tables[0].Rows[count].ItemArray[6].ToString()
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
