using System;

namespace ClassLibrary
{
    public class clsIngredient
    {
        //private data member for the Ingredient ID  property 
        private Int32 mIngredientID;
        //private data member for Ingredient Quantity 
        private Int32 mIngredientQuantity;
        //private data member for Ingredient Name
        private string mIngredientName;
        //private data member for Cake ID
        private Int32 mCakeID;
        //private data member for Ingredient Date Added
        private DateTime mDateAdded;
        //private data member for active
        private Boolean mActive; 


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

        //public property for active
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


        //public property for active
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //public property for IngredientID 
        public int IngredientID
        {
            get
            {
                //return th eprivate dat
                return mIngredientID;
            }
            set
            {
                //set the value of the rivate data member
                mIngredientID = value;
            }
        }

        //public property for active   
        public string IngredientName
        {
            get
            {
                //return the private data
                return mIngredientName;
            }
            set
            {
                //set the value of the private data member
                mIngredientName = value; 
            }
        }

        //public property for the IngredientQuantity
        public int IngredientQuantity 
        {
            get
            {
                //return the private data
                return mIngredientQuantity;
            }
            set
            {
                //set the value of the private data member
                mIngredientQuantity = value; 
            }
        }



        public bool Find(int IngredientID) 
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the IngredientID to search for
            DB.AddParameter("@IngredientID", IngredientID);
            //execute the store procedure
            DB.Execute("sproc_tblIngredient_FilterByIngredientID");
            //if one record is found  (there should be either 1 or 0 !)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member

                mIngredientID = Convert.ToInt32(DB.DataTable.Rows[0]["IngredientID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mIngredientName = Convert.ToString(DB.DataTable.Rows[0]["IngredientName"]);
                mIngredientQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["IngredientQuantity"]);
                mCakeID = Convert.ToInt32(DB.DataTable.Rows[0]["CakeID"]);
                //return that everthing worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false, indicatinf problem 
                return false; 
            }
 
        }

        public bool Valid(string IngredientName, string DateAdded)
        {
            //create  a boolean variable to flah the error
            Boolean OK = true;
            //create a temporary variable to store date values
            DateTime DateTemp;

            //if the IngredientName is blank
            if (IngredientName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Ingredient name is greater than 20 characters
            if (IngredientName.Length > 20)
            {
                //set the flag OK to false
                OK = false;
            }



            //try the date validation assuming the data is a valid date
            try
            {
                DateTemp = Convert.ToDateTime(DateAdded);   
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date) 
                {
                    //set the flag OK to false
                    OK = false;
                }
                //check to see if the date is greater than today's date
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

            
            //return the value ok
            return OK; 
        }
    }
}