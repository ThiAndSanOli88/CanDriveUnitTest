using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CanDriveUnitTest
{

    [TestClass]
    public class UnitTest1
    {
        public bool CanDrive(int age)
        {
            if (age <= 0 || age > 120)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Age must be between 1 and 120.");
            }
            const int drivingAge = 16;
            return age >= drivingAge;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod1()
        {
            CanDrive(int.MinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod2()
        {
            CanDrive(int.MinValue + 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod3()
        {
            CanDrive(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod4()
        {
            CanDrive(0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsFalse(CanDrive(1));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsFalse(CanDrive(15));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(CanDrive(16));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.IsTrue(CanDrive(30));
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(CanDrive(120));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]    
        public void TestMethod10()
        {
            CanDrive(121);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod11()
        {
            CanDrive(int.MaxValue - 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod12()
        {
            CanDrive(int.MaxValue);
        }
    }
}
