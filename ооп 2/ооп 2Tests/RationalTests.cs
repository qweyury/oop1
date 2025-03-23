using Microsoft.VisualStudio.TestTools.UnitTesting;
using ооп_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ооп_2.Tests
{
    [TestClass]
    public class RationalTests
    {
        [TestMethod]
        public void TestRationalConstructor_ValidDenominator()
        {
            
            int numerator = 3;
            int denominator = 4;

            
            var rational = new Rational(numerator, denominator);

            
            Assert.AreEqual(3, rational.Numerator);
            Assert.AreEqual(4, rational.Denominator);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRationalConstructor_DenominatorZero_ThrowsException()
        {
            
            int numerator = 1;
            int denominator = 0;

            
            var rational = new Rational(numerator, denominator);
        }

        [TestMethod]
        public void TestToString_ValidRationalNumber()
        {
            
            var rational = new Rational(3, 4);

            
            var result = rational.ToString();

            
            Assert.AreEqual("3/4", result);
        }

        [TestMethod]
        public void TestToString_SimplifiedRational()
        {
           
            var rational = new Rational(4, 8);

            
            var result = rational.ToString();

            
            Assert.AreEqual("1/2", result);
        }

        [TestMethod]
        public void TestAddition()
        {
            
            var rational1 = new Rational(1, 2);
            var rational2 = new Rational(1, 3);

           
            var result = rational1 + rational2;

            
            Assert.AreEqual(new Rational(5, 6), result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            
            var rational1 = new Rational(3, 4);
            var rational2 = new Rational(1, 4);

            
            var result = rational1 - rational2;

            
            Assert.AreEqual(new Rational(1, 2), result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
           
            var rational1 = new Rational(1, 2);
            var rational2 = new Rational(2, 3);

           
            var result = rational1 * rational2;

            
            Assert.AreEqual(new Rational(1, 3), result);
        }

        [TestMethod]
        public void TestDivision()
        {
           
            var rational1 = new Rational(3, 4);
            var rational2 = new Rational(2, 3);

            
            var result = rational1 / rational2;

            
            Assert.AreEqual(new Rational(9, 8), result);
        }

        [TestMethod]
        public void TestNegativeRational()
        {
            
            var rational = new Rational(3, 4);

            
            var result = -rational;

            
            Assert.AreEqual(new Rational(-3, 4), result);
        }

        [TestMethod]
        public void TestEquality_True()
        {
            
            var rational1 = new Rational(1, 2);
            var rational2 = new Rational(1, 2);

            
            Assert.IsTrue(rational1 == rational2);
        }

        [TestMethod]
        public void TestEquality_False()
        {
            
            var rational1 = new Rational(1, 2);
            var rational2 = new Rational(2, 3);

            Assert.IsFalse(rational1 == rational2);
        }

        [TestMethod]
        public void TestGreaterThan_True()
        {
            
            var rational1 = new Rational(3, 4);
            var rational2 = new Rational(1, 2);

            
            Assert.IsTrue(rational1 > rational2);
        }
        [TestMethod]
        public void TestGreaterThan_False()
        {
            
            var rational1 = new Rational(1, 2);
            var rational2 = new Rational(3, 4);

            Assert.IsFalse(rational1 > rational2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZeroException()
        {
            
            var rational1 = new Rational(1, 2);
            var rational2 = new Rational(0, 1);

            
            var result = rational1 / rational2;
        }
    }
}