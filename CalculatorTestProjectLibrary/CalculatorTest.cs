using NUnit.Framework;
using System;
using UnitTestDemo;
namespace CalculatorTestProjectLibrary
{
    [TestFixture]
    public class CalculatorTest//: IDisposable
    {
        Calculator calc;
        public void SetUp()
        {
            calc = new Calculator();
        }
        //[TearDown]
        //public void TearDown()
        //{
        //    calc.Dispose();
        //}


        [Test,Order(3)]
        
        public void Test_Addition_with_valid_Integer()
        {
           var calc = new Calculator();
            var res = calc.Addition(4, 3);
            Assert.AreEqual(7, res);

            var res1 = calc.Addition(4, 3);
            Assert.AreEqual(7, res1);
        }
        [Test,Order(2)]
        public void Test_subtraction_with_valid_negativeIntegers()
        {
           var calc = new Calculator();
            var res = calc.subtraction(120, 70);
            Assert.AreEqual(50, res);
        }

        [Test,Order(1)]
        [TestCase(30,20,10)]
        [TestCase(400,300,100)]
        [TestCase(500,200,300)]
        public void Test_Sub_with_multiple(int x, int y, int expectedres)
        {
           var calc = new Calculator();
            var res = calc.subtraction(x, y);
            Assert.AreEqual(expectedres, res);
        }

    }
}
