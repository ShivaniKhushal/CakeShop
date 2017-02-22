using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AOrder);
        }

        [TestMethod]
        public void CakeIDOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 CakeID = 2;
            //assign data to the property
            AnOrder.CakeID = CakeID;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CakeID, CakeID);
        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 CustomerID = 3;
            //assign data to the property
            AnOrder.CustomerID = CustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, CustomerID);
        }
        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime OrderDate = DateTime.Now.Date;
            //assign data to the property
            AnOrder.OrderDate = OrderDate;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, OrderDate);
        }

        [TestMethod]
        public void OrderIDOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 OrderID = 25;
            //assign data to the property
            AnOrder.OrderID = OrderID;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, OrderID);
        }
        [TestMethod]
        public void OrderQuantityOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 OrderQuantity = 1;
            //assign data to the property
            AnOrder.OrderQuantity = OrderQuantity;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderQuantity, OrderQuantity);
        }

        [TestMethod]
        public void OrderStatusOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
             Boolean OrderStatus = false;
            //assign data to the property
            AnOrder.OrderStatus = OrderStatus;                                                                                                                                
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, OrderStatus);
        }

        [TestMethod]
        public void CustomerNameOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string CustomerName = "Anjana Gurung";
            //assign data to the property
            AnOrder.CustomerName = CustomerName;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerName, CustomerName);
        }

        [TestMethod]
        public void CakeNameOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string CakeName = "Lemon Cheese Cake";
            //assign data to the property
            AnOrder.CakeName = CakeName;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CakeName, CakeName);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id 
            if (AnOrder.OrderID != 2)
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
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.CakeID != 2)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.CustomerID != 3)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("18/02/2017"))
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOrderQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderQuantity != 1)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderStatus != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.CustomerName != "Anjana Gurung")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerName = "Anjana Gurung";
            string CakeName = "Lemon Cheese Cake";
            string OrderDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "";
            string CakeName = "Lemon Cheese Cake";
            string OrderDate = "18/02/2017";
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
      
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "a";
            string CakeName = "Lemon Cheese Cake";
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "aa";
            string CakeName = "Lemon Cheese Cake";
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49, 'a');
            string CakeName = "Lemon Cheese Cake";
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'a');
            string CakeName = "Lemon Cheese Cake";
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'a');
            string CakeName = "Lemon Cheese Cake";
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'a');
            string CakeName = "Lemon Cheese Cake";
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CakeNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "";
            string OrderDate = "18/02/2017";
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void CakeNameMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "a";
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CakeNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "aa";
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CakeNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "";
            CakeName = CakeName.PadRight(49, 'a');
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CakeNameMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "";
            CakeName = CakeName.PadRight(50, 'a');
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CakeNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "";
            CakeName = CakeName.PadRight(51, 'a');
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void CakeNameMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "";
            CakeName = CakeName.PadRight(25, 'a');
            string OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "Lemon Cheese Cake";
            //create a varibale to store the test date data
            DateTime TestDate;
            //set the date today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "Lemon Cheese Cake";
            //create a varibale to store the test date data
            DateTime TestDate;
            //set the date today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "Lemon Cheese Cake";
            //create a varibale to store the test date data
            DateTime TestDate;
            //set the date today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "Lemon Cheese Cake";
            //create a varibale to store the test date data
            DateTime TestDate;
            //set the date today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "Lemon Cheese Cake";
            //create a varibale to store the test date data
            DateTime TestDate;
            //set the date today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methods
            string CustomerName = "Anjana Gurung";
            string CakeName = "Lemon Cheese Cake";
            //set the order date to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            OK = AnOrder.Valid(CustomerName, CakeName, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
    }


    }
