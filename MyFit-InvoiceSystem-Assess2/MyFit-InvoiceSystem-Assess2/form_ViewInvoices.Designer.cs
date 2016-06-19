namespace MyFit_InvoiceSystem_Assess2
{
    partial class form_ViewInvoices
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.CusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdIndCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdOrderCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusNumber,
            this.CusName,
            this.CusAddress,
            this.ProdType,
            this.ProdQuantity,
            this.ProdIndCost,
            this.ProdOrderCost});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 499);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(721, 528);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(146, 67);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(896, 528);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(146, 67);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // CusNumber
            // 
            this.CusNumber.HeaderText = "ID Number";
            this.CusNumber.Name = "CusNumber";
            // 
            // CusName
            // 
            this.CusName.HeaderText = "Name";
            this.CusName.Name = "CusName";
            // 
            // CusAddress
            // 
            this.CusAddress.HeaderText = "Address";
            this.CusAddress.Name = "CusAddress";
            // 
            // ProdType
            // 
            this.ProdType.HeaderText = "Product Type";
            this.ProdType.Name = "ProdType";
            // 
            // ProdQuantity
            // 
            this.ProdQuantity.HeaderText = "Product Quantity";
            this.ProdQuantity.Name = "ProdQuantity";
            // 
            // ProdIndCost
            // 
            this.ProdIndCost.HeaderText = "Cost Per Item";
            this.ProdIndCost.Name = "ProdIndCost";
            // 
            // ProdOrderCost
            // 
            this.ProdOrderCost.HeaderText = "Total Cost";
            this.ProdOrderCost.Name = "ProdOrderCost";
            // 
            // form_ViewInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 607);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_ViewInvoices";
            this.Text = "form_ViewInvoices";
            this.Load += new System.EventHandler(this.form_ViewInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdIndCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdOrderCost;
    }
}