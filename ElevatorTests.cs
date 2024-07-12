using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elevator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace Elevator.Tests
{
    [TestClass()]
    public class ElevatorTests
    {
                
        [TestMethod()]
        public void callElevatorInvalidFloorTest()
        {
            var eletest1 = new Elevator(5);

            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                eletest1.callElevator(6);

                Assert.IsTrue(writer.ToString().Contains("Invalid request for floor: 6"));
            }

         }

        [TestMethod()]
        public void callElevatorValidFloorTest()
        {
            var eletest2 = new Elevator(5);

            eletest2.callElevator(2);

            Assert.IsTrue(eletest2.floorrequests.Contains(2));
        }

        [TestMethod()]
        public void invalidGotoFloorTest()
        {
            var eletest3 = new Elevator(5);

            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                eletest3.goToFloor(6);

                Assert.IsTrue(writer.ToString().Contains("Invalid request for floor: 6"));
            }

        }

        [TestMethod()]
        public void validGotoFloorTest()
        {
            var eletest4 = new Elevator(5);

            eletest4.goToFloor(3);

            Assert.IsTrue(eletest4.floorrequests.Contains(3));
        }

                

        [TestMethod()]
        public void startElevatorTest()
        {
            var eletest5 = new Elevator(5);

           

            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                eletest5.goToFloor(4);
                eletest5.startElevator();

                Assert.IsTrue(writer.ToString().Contains("Landed at floor: 4"));
            }

        }
    }
}