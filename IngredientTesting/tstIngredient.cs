using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstIngredient
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the 
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //test to see that it exists
            Assert.IsNotNull(AnIngredient);  
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnIngredient.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.Active, TestData);  
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnIngredient.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.DateAdded, TestData);  
        }


        [TestMethod]
        public void CakeIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnIngredient.CakeID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.CakeID, TestData);  
        }

        [TestMethod]
        public void IngredientIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnIngredient.IngredientID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.IngredientID, TestData); 
        }

        [TestMethod]
        public void IngredientQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnIngredient.IngredientQuantity = TestData; 
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.IngredientQuantity, TestData);    
        }

        [TestMethod]
        public void IngredientNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //create some test data to assign to the property
            string TestData = "Egg";
            //assign the data to the property
            AnIngredient.IngredientName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnIngredient.IngredientName, TestData);  
        }


        //method find --------------------// 


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 IngredientID = 1;
            //invoke the method
            Found = AnIngredient.Find(IngredientID);
            //test to see that the result is correct
            Assert.IsTrue(Found); 
        }


        [TestMethod]
        public void TestIngredientIDFound()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IngredientID = 1;
            //invoke the method
            Found = AnIngredient.Find(IngredientID);
            //check the address no
            if (AnIngredient.IngredientID != 1)  
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIngredientQuantityFound()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IngredientID = 1;
            //invoke the method
            Found = AnIngredient.Find(IngredientID);
            //check the address no
            if (AnIngredient.IngredientQuantity != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCakeIDFound()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IngredientID = 1;
            //invoke the method
            Found = AnIngredient.Find(IngredientID); 
            //check the property
            if (AnIngredient.CakeID != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK); 
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IngredientID = 1;
            //invoke the method
            Found = AnIngredient.Find(IngredientID); 
            //check the property
            if (AnIngredient.DateAdded != Convert.ToDateTime("21/02/2017")) 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK); 
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IngredientID = 1;
            //invoke the method
            Found = AnIngredient.Find(IngredientID);
            //check the property
            if (AnIngredient.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIngredientNameFound()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IngredientID = 1;
            //invoke the method
            Found = AnIngredient.Find(IngredientID);
            //check the property
            if (AnIngredient.IngredientName != "Egg")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK); 
        }

        // validation method for Ingredient Name-----------------------------//



        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string IngredientName = "Egg";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded); 
            //test to see that the result is correct 
            Assert.IsTrue(OK);  
        }

        [TestMethod]
        public void IngredientNameMinLessOne()  
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = ""; //this should trigger an error 
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);  
        }

        [TestMethod]
        public void IngredientNameMin()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "E"; //this should be ok 

            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void IngredientNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Eg"; //this should be ok 
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void IngredientNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Egggggggggggggggggg"; //this should be ok 
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void IngredientNameMax()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Eggggggggggggggggggg"; //this should be ok 
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
            //test to see that the result is correct
            Assert.IsTrue(OK);  
        }


        [TestMethod]
        public void IngredientNameMid()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Eggggggggg"; //this should be ok 
           
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void IngredientNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Egggggggggggggggggggg"; //this should be ok 
            
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void IngredientNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Egggggggggggggggggggggggggggggggggggggggggggggggggggggg";
            IngredientName = IngredientName.PadRight(500, 'a'); //this should fail 
                  
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
           
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        // from this point its method for DateAdded ----------------------------//


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Egg"; 
              
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient(); 
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Egg";
           
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Egg";
           
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Egg";
            string IngredientQuantity = "2";
            string CakeID = "11";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Egg";
          
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsIngredient AnIngredient = new clsIngredient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string IngredientName = "Egg";
          
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            OK = AnIngredient.Valid(IngredientName, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);  
        }

    }
}
