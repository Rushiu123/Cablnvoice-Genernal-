using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoice_Generator
{
    [TestClass]
    public class InvoiceTest
    {
        public object Assert { get; private set; }

        [DataRow(15, 10, 160)]
        [DataRow(30, 3, 303)]
        [TestMethod]
        public void GivenProperTimeAndDistanceShouldPass(double distance, int time, double expected)
        {
            Ride ride = new Ride();
            double actual = ride.CalculateFare(distance, time);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
