namespace MyFit_InvoiceSystem_Assess2
{
    partial class form_ViewCustomers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CusNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusSuburb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusPostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusNum,
            this.CusName,
            this.CusPhoneNum,
            this.CusAddress,
            this.CusSuburb,
            this.CusCity,
            this.CusPostCode,
            this.CusState});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(961, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // CusNum
            // 
            this.CusNum.HeaderText = "ID Number";
            this.CusNum.Name = "CusNum";
            // 
            // CusName
            // 
            this.CusName.HeaderText = "Name";
            this.CusName.Name = "CusName";
            // 
            // CusPhoneNum
            // 
            this.CusPhoneNum.HeaderText = "Contact Number";
            this.CusPhoneNum.Name = "CusPhoneNum";
            // 
            // CusAddress
            // 
            this.CusAddress.HeaderText = "Address";
            this.CusAddress.Name = "CusAddress";
            // 
            // CusSuburb
            // 
            this.CusSuburb.HeaderText = "Suburb";
            this.CusSuburb.Name = "CusSuburb";
            // 
            // CusCity
            // 
            this.CusCity.HeaderText = "City";
            this.CusCity.Name = "CusCity";
            // 
            // CusPostCode
            // 
            this.CusPostCode.HeaderText = "Postcode";
            this.CusPostCode.Name = "CusPostCode";
            // 
            // CusState
            // 
            this.CusState.HeaderText = "State";
            this.CusState.Name = "CusState";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(827, 455);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(146, 67);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(652, 455);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(146, 67);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // form_ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 534);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_ViewCustomers";
            this.Text = "form_ViewCustomers";
            this.Load += new System.EventHandler(this.form_ViewCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusSuburb;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusPostCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusState;
    }
}