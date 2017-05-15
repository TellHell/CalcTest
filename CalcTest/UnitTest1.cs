using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            //Arrange
            var test = new CalcLibrary.Calc();

            //Act
            var result = test.Sum(1, 2);
            var result2 = test.Sum(3, 5);
            /*
             * more
             * */

            //Assert
            Assert.AreEqual(result, 3);
            Assert.AreEqual(result2, 8);
            /*
             * more
             * */
        }
    }
}
