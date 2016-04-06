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
    }
}
