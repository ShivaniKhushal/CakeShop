using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the CustomerID property
        private Int32 mCustomerID;
        //private data member for Active
        private Boolean mActive;
        //private data member for the Address
        private string mAddress;
        //private data member for Date Registered
        private DateTime mDateRegistered;
        //private data member for Email Address
        private string mEmailAddress;
        //private data member for Firstname
        private string mFirstname;
        //private data member for Surname
        private string mSurname;
        //private data member for Password
        private string mPassword;
        //private data member for TelephoneNumber
        private string mTelephoneNumber;


        //public property for active
        public bool Active
        {
            get
            {
                //return the private data 
                return mActive;
            }
            set
            {
                //set the private data 
                mActive = value;
            }
        }

        //public property for address
        public string Address
        {
            get
            {
                //return the private data 
                return mAddress;
            }
            set
            {
                //set the private data
                mAddress = value;
            }
        }

        //public property for the customer id
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

        //public property for date registered
        public DateTime DateRegistered
        {
            get
            {
                //return the private data 
                return mDateRegistered;
            }
            set
            {
                //set the private data
                mDateRegistered = value;
            }
        }

        //public property for email address
        public string EmailAddress
        {
            get
            {
                //return the private data 
                return mEmailAddress;
            }
            set
            {
                //set the private data 
                mEmailAddress = value;
            }
        }

        //public property for firstname
        public string Firstname
        {
            get
            {
                //return the private data 
                return mFirstname;
            }
            set
            {
                //set the private data 
                mFirstname = value;
            }
        }

        //public property for surname
        public string Surname
        {
            get
            {
                //return the private data 
                return mSurname;
            }
            set
            {
                //set the private data 
                mSurname = value;
            }
        }

        //public property for password
        public string Password
        {
            get
            {
                //return the private data 
                return mPassword;
            }
            set
            {
                //set the private data 
                mPassword = value;
            }
        }

        //public property for TelephoneNumber
        public string TelephoneNumber
        {
            get
            {
                //return the private data 
                return mTelephoneNumber;
            }
            set
            {
                //set the private data 
                mTelephoneNumber = value;
            }
        }
      
        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for 
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDateRegistered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateRegistered"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mFirstname = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mTelephoneNumber = Convert.ToString(DB.DataTable.Rows[0]["TelephoneNumber"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public bool Valid(string Address, string DateRegistered, string EmailAddress, string Firstname, string Surname, string Password, string TelephoneNumber)
        {
            //create a Boolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Address is blank
            if (Address.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the address is greater than 50 characters 
            if (Address.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the firstname is blank
            if (Firstname.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the firstname is greater than 50 characters 
            if (Firstname.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the surname is blank
            if (Surname.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the surname is greater than 50 characters 
            if (Surname.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the email address is blank
            if (EmailAddress.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the email address is greater than 50 characters 
            if (EmailAddress.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the password is blank
            if (Password.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the password is greater than 16 characters 
            if (Password.Length > 16)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the telephone number is blank
            if (TelephoneNumber.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the telephone number is greater than 11 characters 
            if (TelephoneNumber.Length > 11)
            {
                //set the flag OK to false
                OK = false;
            }
            //try the date validation assuming the data is a valid date
            try
            {
                //copy the DateRegistered value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateRegistered);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the falg OK to false
                    OK = false;
                }
            }

                //the date was not a date so flag an error
            catch
            {
                //set the flag OK to false
                OK = false;
            }
            //return the value OK
            return OK;
        }
    }
}