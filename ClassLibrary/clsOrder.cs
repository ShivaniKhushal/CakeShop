using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the OrderID property
        private Int32 mOrderID;
        //private data member for the CakeID
        private Int32 mCakeID;
        //private data member for the CustomerID property
        private Int32 mCustomerID;
        //private data member for the OrderDate property
        private DateTime mOrderDate;
        //private data member for the OrderQuantity property
        private Int32 mOrderQuantity;
        //private data member for the OrderStatus property
        private Boolean mOrderStatus;
        //private data member for the CustomerName property
        private string mCustomerName;
        //private data member for the CakeName property
        private string mCakeName;

        //public property for the CakeID property
        public int CakeID
        {
            get
            {
                //return the private data
                return mCakeID;
            }
            set
            {
                //set the value of the private data member
                mCakeID = value;
            }
        }

        //public property for the customer id property
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }

        //public property for the cake name property
        public string CakeName
        {
            get
            {
                //return the private data
                return mCakeName;
            }
            set
            {
                //set the value of the private data member
                mCakeName = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mOrderDate;
            }
            set
            {
                //set the value of the private date member
                mOrderDate = value;
            }
        }

        //public property for the order id 
        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data member
                mOrderID = value;
            }
        }
        public int OrderQuantity
        {
            get
            {
                //return the private data
                return mOrderQuantity;
            }
            set
            {
                //set the value of the private data member
                mOrderQuantity = value;
            }
        }
        public bool OrderStatus
        {
            get
            {
                //return the private data
                return mOrderStatus;
            }
            set
            {
                //set the value of the private data member
                mOrderStatus = value;
            }
        }
        public string CustomerName
        {
            get
            {
                //return the private data
                return mCustomerName;
            }
            set
            {
                //set the value of the private data member
                mCustomerName = value;
            }
        }

        public bool Find(int OrderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the store procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCakeID = Convert.ToInt32(DB.DataTable.Rows[0]["CakeID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["OrderQuantity"]);
                mOrderStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderStatus"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCakeName = Convert.ToString(DB.DataTable.Rows[0]["CakeName"]);
                //return that everything worked Ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public bool Valid(string CustomerName, string CakeName, string OrderDate)
        {
            //create a boolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store data values
            DateTime DateTemp;
            //if the CustomerName is blank
            if (CustomerName.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the CustomerName is greater than 50 characters
            if (CustomerName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //try the date validation assuming the data is a valid date
            try
            {
                //copy the DateAdded value to the Datetemp variable
                DateTemp = Convert.ToDateTime(OrderDate);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
            //the data was not a date so flag an error
            catch
            {
                //set the flag OK to false
                OK = false;
            }
            //is the customer name blank
            if (CustomerName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the customer name is too long
            if (CustomerName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //is the cake name blank
            if (CakeName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the cake name is too long
            if (CakeName.Length > 50)
            {
                //set the flag Ok false
                OK = false;
            }

            //return the value of OK
            return OK;
        }
    }
}