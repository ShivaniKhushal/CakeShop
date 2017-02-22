using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestMethod
{
    [TestClass]
    public class tstCake
    {
        public object AnCake { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCake AnCake = new clsCake();
            //test to see that it exists
            Assert.IsNotNull(AnCake);
        }

        [TestMethod]
        public void ActiveOK()
        { // create an instance of the class i want to create
            clsCake AnCake = new clsCake();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCake.Active = TestData;
            // test to see that the two vaule are the same
            Assert.AreEqual(AnCake.Active, TestData);
        }

        [TestMethod]
        public void IDOK()
        {
            clsCake AnCake = new clsCake();
            Int32 TestData = 0;
            AnCake.ID = TestData;
            Assert.AreEqual(AnCake.ID, TestData);
        }

        [TestMethod]
        public void NameOK()
        {
            clsCake AnCake = new clsCake();
            String TestData = "";
            AnCake.Name = TestData;
            Assert.AreEqual(AnCake.Name, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsCake AnCake = new clsCake();
            Decimal TestData = 00.00M;
            AnCake.Price = TestData;
            Assert.AreEqual(AnCake.Price, TestData);
        }
        [TestMethod]
        public void SizeOK()
        {
            clsCake AnCake = new clsCake();
            Int32 TestData = 1;
            AnCake.Size = TestData;
            Assert.AreEqual(AnCake.Size, TestData);
        }
    }
}

