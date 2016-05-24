using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFit_InvoiceSystem_Assess2
{
    class Invoice
    {
        private int CustomerIDNum;
        private string CustomerName;
        private string CustomerAddress;
        private string ProductType;
        private int ProductQuantity;
        private double ProductCostPerItem;
        private double ProductTotalCost;

        public Invoice()
        {
            CustomerIDNum = 0;
            CustomerName = "No customer name set";
            CustomerAddress = "No customer address set";
            ProductType = "No product type set";
            ProductQuantity = 0;
            ProductCostPerItem = 0;
            ProductTotalCost = 0;
        }

        public int setCustomerIDNum
        {
            set { CustomerIDNum = value; }
            get { return CustomerIDNum; }
        }

        public string setCustomerName
        {
            set { CustomerName = value; }
            get { return CustomerName; }
        }

        public string setCustomerAddress
        {
            set { CustomerAddress = value; }
            get { return CustomerAddress; }
        }

        public string setProductType
        {
            set { ProductType = value; }
            get { return ProductType; }
        }

        public int setProductQuantity
        {
            set { ProductQuantity = value; }
            get { return ProductQuantity; }
        }

        public double setProductCostPerItem
        {
            set { ProductCostPerItem = value; }
            get { return ProductCostPerItem; }
        }

        public double setProductTotalCost
        {
            set { ProductTotalCost = value; }
            get { return ProductTotalCost; }
        }
    }
}
