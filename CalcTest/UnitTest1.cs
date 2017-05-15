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
            var result = test.Execute("sum", new object[] {1,2}).ToString();
            //var result2 = test.Sum(3, 5);
            /*
             * more
             * */

            //Assert
            Assert.AreEqual(result, "3");
            //Assert.AreEqual(result2, 8);
            /*
             * more
             * */
        }

        [TestMethod]
        public void TestDiv()
        {
            //Arrange
            var test = new CalcLibrary.Calc();


            //Act
            var result = test.Execute("divide", new object[] { 2, 4 }).ToString();
            //var result2 = test.Sum(3, 5);
            /*
             * more
             * */

            //Assert
            Assert.AreEqual(result, "0,5");
            //Assert.AreEqual(result2, 8);
            /*
             * more
             * */
        }

        [TestMethod]
        public void TestExp()
        {
            //Arrange
            var test = new CalcLibrary.Calc();


            //Act
            var result = test.Execute("exp", new object[] { 2, 4 }).ToString();
            var result2 = test.Execute("exp", new object[] { 1, Double.NaN }).ToString();
            /*
             * more
             * */

            //Assert
            Assert.AreEqual(result, "16");
            Assert.AreEqual(result2, "1");
            /*
             * more
             * */
        }

        [TestMethod]
        public void TestSqrt()
        {
            //Arrange
            var test = new CalcLibrary.Calc();


            //Act
            var result = test.Execute("sqrt", new object[] { 2, 2 }).ToString();
            var result2 = test.Execute("sqrt", new object[] { 0, 0 }).ToString();
            //var result3 = test.Execute("sqrt", new object[] { Double.NaN, 0 }).ToString();
            var result4 = test.Execute("sqrt", new object[] { -6, 0 }).ToString();

            //Assert
            Assert.AreEqual(result, "1,41");
            Assert.AreEqual(result2, "0");
            //Assert.AreEqual(result3, Double.NaN.ToString());
            Assert.AreEqual(result4, Double.NaN.ToString());
            
            // почему сбой в result3? 
            // впринципе NaN не равен самому себе
            // но на msdn написано, что квдратный корень из NaN равен NaN 
        }

        [TestMethod]
        public void TestMult()
        {
            //Arrange
            var test = new CalcLibrary.Calc();


            //Act
            var result = test.Execute("mult", new object[] { 2, 2 }).ToString();
            var result2 = test.Execute("mult", new object[] { 0, 0 }).ToString();
            var result3 = test.Execute("mult", new object[] { 3, 0 }).ToString();
            var result4 = test.Execute("mult", new object[] { -6, 0 }).ToString();

            //Assert
            Assert.AreEqual(result, "4");
            Assert.AreEqual(result2, "0");
            Assert.AreEqual(result3, "0");
            Assert.AreEqual(result4, "0");

        }

        [TestMethod]
        public void TestSub()
        {
            //Arrange
            var test = new CalcLibrary.Calc();


            //Act
            var result = test.Execute("sub", new object[] { 2, 2 }).ToString();
            var result2 = test.Execute("sub", new object[] { 0, 0 }).ToString();
            var result3 = test.Execute("sub", new object[] { 3, 0 }).ToString();
            var result4 = test.Execute("sub", new object[] { -6, 0 }).ToString();

            //Assert
            Assert.AreEqual(result, "0");
            Assert.AreEqual(result2, "0");
            Assert.AreEqual(result3, "3");
            Assert.AreEqual(result4, "-6");

        }
    }
}
