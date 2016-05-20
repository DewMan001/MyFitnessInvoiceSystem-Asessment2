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
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();
        }

        int failCount = 0;

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            //declaring username variable
            string Username;
            //And putting in the text from the textbox
            Username = txt_Username.Text;

            //declaring password variable
            string Password;
            //And putting the text from textbox into the variable
            Password = txt_Password.Text;

            if (Username == "MyFitness" && Password == "pass")
            {
                this.Hide();
                form_MainMenu SwitchToMain = new form_MainMenu();
                SwitchToMain.Show();
            }
            else
            { 
                //MessageBox for an error message
                MessageBox.Show("Sorry, but those credentials are incorrect");
            }
        }
    }
}
