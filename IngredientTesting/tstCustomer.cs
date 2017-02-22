using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActiveOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            Boolean Active = true;
            //assign the data to the property
            ACustomer.Active = Active;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, Active);
        }

        [TestMethod]
        public void AddressOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String Address = "1a";
            //assign the data to the property
            ACustomer.Address = Address;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, Address);
        }

        [TestMethod]
        public void CustomerIDOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            Int32 CustomerID = 1;
            //assign the data to the property
            ACustomer.CustomerID = CustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, CustomerID);
        }

        [TestMethod]
        public void DateRegisteredOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            DateTime DateRegistered = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateRegistered = DateRegistered;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateRegistered, DateRegistered);
        }

        [TestMethod]
        public void EmailAddressOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String EmailAddress = "s_1@homtail.co.uk";
            //assign the data to the property
            ACustomer.EmailAddress = EmailAddress;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.EmailAddress, EmailAddress);
        }

        [TestMethod]
        public void FirstnameOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String Firstname = "shivani";
            //assign the data to the property
            ACustomer.Firstname = Firstname;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Firstname, Firstname);
        }

        [TestMethod]
        public void SurnameOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String Surname = "khushal";
            //assign the data to the property
            ACustomer.Surname = Surname;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Surname, Surname);
        }

        [TestMethod]
        public void PasswordOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String Password = "abc";
            //assign the data to the property
            ACustomer.Password = Password;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Password, Password);
        }

        [TestMethod]
        public void TelephoneNumberOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            String TelephoneNumber = "01163456788";
            //assign the data to the property
            ACustomer.TelephoneNumber = TelephoneNumber;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.TelephoneNumber, TelephoneNumber);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolen variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 CustomerID = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerID != 5)
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
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.Address != "72 Freedom Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateRegisteredFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.DateRegistered !=Convert.ToDateTime("20/09/2016"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.EmailAddress != "Freedom@hotmail.co.uk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.Firstname != "Jasmine")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.Surname != "Flex")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.Password != "County5")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTelephoneNumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.TelephoneNumber != "01165678901")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = ""; //this should trigger an error
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "a"; //this should be ok
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "aa"; //this should be ok
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = ""; 
            Address = Address.PadRight(500, 'a'); //this should fail
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street"; 
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = ""; //this should trigger an error
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street"; 
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "A";//this should be ok
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street"; 
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Al"; //this should be ok
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street"; 
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "AlexsAlexsAlexsAlexsAlexsAlexsAlexsAlexsAlexsAlex"; //this should be ok
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street"; 
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "AlexsAlexsAlexsAlexsAlexsAlexsAlexsAlexsAlexsAlexs"; //this should be ok
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street"; 
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "AlexsAlexsAlexsAlexsAlexs"; //this should be ok
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street"; 
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "AlexsAlexsAlexsAlexsAlexsAlexsAlexsAlexsAlexsAlexsA"; //this should fail
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "";
            Firstname = Firstname.PadRight(500, 'a'); //this should fail
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex"; 
            string Surname = ""; //this should trigger an error
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SurnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "P"; //this should be ok
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex"; 
            string Surname = "Pa"; // this should be ok
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex"; 
            string Surname = "ParkerssssParkerssssParkerssssParkerssssParkersss"; // this should be ok
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "ParkerssssParkerssssParkerssssParkerssssParkerssss"; //this should be ok
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex"; 
            string Surname = "ParkerssssParkerssssParke"; //this should be ok
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "ParkerssssParkerssssParkerssssParkerssssParkerssssP"; //this should fail
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "";
            Surname = Surname.PadRight(500, 'a'); //this should fail
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = ""; //this should trigger an error
            string Firstname = "Alex";
            string Surname = "Parker"; 
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "a"; //this should be ok
            string Firstname = "Alex";
            string Surname = "Parker"; 
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "aa"; // this should be ok
            string Firstname = "Alex";
            string Surname = "Parker"; 
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";// this should be ok
            string Firstname = "Alex";
            string Surname = "Parker"; 
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            string Firstname = "Alex";
            string Surname = "Parker"; 
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            string Firstname = "Alex";
            string Surname = "Parker"; 
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            string Firstname = "Alex";
            string Surname = "Parker"; 
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = ""; //this should fail
            EmailAddress = EmailAddress.PadRight(500, 'a');
            string Firstname = "Alex";
            string Surname = "";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk"; 
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = ""; //this should trigger an error
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk"; 
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "h"; //this should be ok
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk"; 
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "hh"; //this should be ok
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "hhhhhhhhhhhhhhh"; //this should be ok
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk"; 
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "hhhhhhhhhhhhhhhh"; //this should be ok
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk"; 
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "hhhhhhhh"; //this should be ok
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk"; 
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "hhhhhhhhhhhhhhhhh"; //this should fail
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk"; 
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = ""; //this should fail
            Password = Password.PadRight(500, 'h');
            string TelephoneNumber = "01161357956";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelephoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday"; 
            string TelephoneNumber = "";//this should trigger an error
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelephoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday"; 
            string TelephoneNumber = "0"; //this should be ok
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TelephoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday"; 
            string TelephoneNumber = "01"; //this should be ok
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TelephoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday"; 
            string TelephoneNumber = "0123456789"; //this should be ok
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TelephoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday"; 
            string TelephoneNumber = "01234567890"; //this should be fine
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TelephoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday"; 
            string TelephoneNumber = "01234"; //this should be fine
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TelephoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday"; 
            string TelephoneNumber = "012345678901"; //this should be fine
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelephoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string DateRegistered = DateTime.Now.Date.ToString();
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday"; 
            string TelephoneNumber = ""; //this should fail
            TelephoneNumber = TelephoneNumber.PadRight(500, '0');
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateRegisteredExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956"; 
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateRegisteredMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day 
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateRegisteredMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateRegisteredMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateRegisteredExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateRegisteredInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method 
            string Address = "67 Flex Street";
            string EmailAddress = "Alex@hotmail.co.uk";
            string Firstname = "Alex";
            string Surname = "Parker";
            string Password = "Holiday";
            string TelephoneNumber = "01161357956";
            //set the DateRegistered to a non date value
            string DateRegistered = "this is not a date";
            //invoke the method
            OK = ACustomer.Valid(Address, DateRegistered, EmailAddress, Firstname, Surname, Password, TelephoneNumber);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}