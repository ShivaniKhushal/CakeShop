using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFramework
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that is exists
            Assert.IsNotNull(AllOrders);
        }
    }
}
