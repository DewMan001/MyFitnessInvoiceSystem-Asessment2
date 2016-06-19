namespace MyFit_InvoiceSystem_Assess2
{
    partial class form_CreateCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_StartAgain = new System.Windows.Forms.Button();
            this.btn_ViewCustomers = new System.Windows.Forms.Button();
            this.txt_Postcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_CusNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboBox_State = new System.Windows.Forms.ComboBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_Suburb = new System.Windows.Forms.TextBox();
            this.txt_Address2 = new System.Windows.Forms.TextBox();
            this.txt_Address1 = new System.Windows.Forms.TextBox();
            this.txt_PhoneNum = new System.Windows.Forms.TextBox();
            this.txt_CusName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.Location = new System.Drawing.Point(482, 444);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(155, 69);
            this.btn_MainMenu.TabIndex = 13;
            this.btn_MainMenu.Text = "Return to Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 69);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save this Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_StartAgain
            // 
            this.btn_StartAgain.Location = new System.Drawing.Point(482, 100);
            this.btn_StartAgain.Name = "btn_StartAgain";
            this.btn_StartAgain.Size = new System.Drawing.Size(155, 69);
            this.btn_StartAgain.TabIndex = 12;
            this.btn_StartAgain.Text = "Start Again";
            this.btn_StartAgain.UseVisualStyleBackColor = true;
            this.btn_StartAgain.Click += new System.EventHandler(this.btn_StartAgain_Click);
            // 
            // btn_ViewCustomers
            // 
            this.btn_ViewCustomers.Location = new System.Drawing.Point(482, 188);
            this.btn_ViewCustomers.Name = "btn_ViewCustomers";
            this.btn_ViewCustomers.Size = new System.Drawing.Size(155, 69);
            this.btn_ViewCustomers.TabIndex = 22;
            this.btn_ViewCustomers.Text = "View Customers";
            this.btn_ViewCustomers.UseVisualStyleBackColor = true;
            this.btn_ViewCustomers.Click += new System.EventHandler(this.btn_PrintCustomerInfo_Click);
            // 
            // txt_Postcode
            // 
            this.txt_Postcode.Location = new System.Drawing.Point(175, 359);
            this.txt_Postcode.Name = "txt_Postcode";
            this.txt_Postcode.Size = new System.Drawing.Size(181, 26);
            this.txt_Postcode.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Postcode";
            // 
            // txt_CusNum
            // 
            this.txt_CusNum.Location = new System.Drawing.Point(175, 33);
            this.txt_CusNum.Name = "txt_CusNum";
            this.txt_CusNum.Size = new System.Drawing.Size(181, 26);
            this.txt_CusNum.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Customer Number";
            // 
            // cboBox_State
            // 
            this.cboBox_State.FormattingEnabled = true;
            this.cboBox_State.Items.AddRange(new object[] {
            "New South Wales",
            "Western Australia",
            "Queensland",
            "South Australia",
            "Tasmania",
            "Victoria"});
            this.cboBox_State.Location = new System.Drawing.Point(175, 405);
            this.cboBox_State.Name = "cboBox_State";
            this.cboBox_State.Size = new System.Drawing.Size(181, 28);
            this.cboBox_State.TabIndex = 38;
            this.cboBox_State.Text = "Choose a state";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(175, 313);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(181, 26);
            this.txt_City.TabIndex = 36;
            // 
            // txt_Suburb
            // 
            this.txt_Suburb.Location = new System.Drawing.Point(175, 267);
            this.txt_Suburb.Name = "txt_Suburb";
            this.txt_Suburb.Size = new System.Drawing.Size(181, 26);
            this.txt_Suburb.TabIndex = 34;
            // 
            // txt_Address2
            // 
            this.txt_Address2.Location = new System.Drawing.Point(175, 221);
            this.txt_Address2.Name = "txt_Address2";
            this.txt_Address2.Size = new System.Drawing.Size(181, 26);
            this.txt_Address2.TabIndex = 33;
            // 
            // txt_Address1
            // 
            this.txt_Address1.Location = new System.Drawing.Point(175, 175);
            this.txt_Address1.Name = "txt_Address1";
            this.txt_Address1.Size = new System.Drawing.Size(181, 26);
            this.txt_Address1.TabIndex = 31;
            // 
            // txt_PhoneNum
            // 
            this.txt_PhoneNum.Location = new System.Drawing.Point(175, 129);
            this.txt_PhoneNum.Name = "txt_PhoneNum";
            this.txt_PhoneNum.Size = new System.Drawing.Size(181, 26);
            this.txt_PhoneNum.TabIndex = 29;
            // 
            // txt_CusName
            // 
            this.txt_CusName.Location = new System.Drawing.Point(175, 79);
            this.txt_CusName.Name = "txt_CusName";
            this.txt_CusName.Size = new System.Drawing.Size(181, 26);
            this.txt_CusName.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Suburb";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address Line 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Address Line 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Contact Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Name";
            // 
            // form_CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 525);
            this.Controls.Add(this.txt_Postcode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_CusNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboBox_State);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_Suburb);
            this.Controls.Add(this.txt_Address2);
            this.Controls.Add(this.txt_Address1);
            this.Controls.Add(this.txt_PhoneNum);
            this.Controls.Add(this.txt_CusName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ViewCustomers);
            this.Controls.Add(this.btn_StartAgain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_MainMenu);
            this.Name = "form_CreateCustomer";
            this.Text = "Create a Customer";
            this.Load += new System.EventHandler(this.form_CreateCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_StartAgain;
        private System.Windows.Forms.Button btn_ViewCustomers;
        private System.Windows.Forms.TextBox txt_Postcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_CusNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboBox_State;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_Suburb;
        private System.Windows.Forms.TextBox txt_Address2;
        private System.Windows.Forms.TextBox txt_Address1;
        private System.Windows.Forms.TextBox txt_PhoneNum;
        private System.Windows.Forms.TextBox txt_CusName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}