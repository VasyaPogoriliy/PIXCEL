using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba1_Spreadsheet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1_Spreadsheet.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void EvaluateTest1()
        {
            Assert.AreEqual(Calculator.Evaluate("2+2"), 4);
        }

        [TestMethod()]
        public void EvaluateTest2()
        {
            Assert.AreEqual(Calculator.Evaluate("3,15^2"), 9, 9225);
        }

        [TestMethod()]
        public void EvaluateTest3()
        {
            Assert.AreEqual(Calculator.Evaluate("2^(-2)"), 0,25);
        }

        [TestMethod()]
        public void EvaluateTest4()
        {
            Assert.AreEqual(Calculator.Evaluate("-5^5"), -3125);
        }

        [TestMethod()]
        public void EvaluateTest5()
        {
            Assert.AreEqual(Calculator.Evaluate("+2"), 2);
        }

        [TestMethod()]
        public void EvaluateTest6()
        {
            Assert.AreEqual(Calculator.Evaluate("++2"), 2);
        }

        [TestMethod()]
        public void EvaluateTest7()
        {
            Assert.AreEqual(Calculator.Evaluate("-2"), -2);
        }

        [TestMethod()]
        public void EvaluateTest8()
        {
            Assert.AreEqual(Calculator.Evaluate("--2"), 2);
        }

        [TestMethod()]
        public void EvaluateTest9()
        {
            Assert.AreEqual(Calculator.Evaluate("max(3,14;-5,45)"), 3, 14);
        }

        [TestMethod()]
        public void EvaluateTest10()
        {
            Assert.AreEqual(Calculator.Evaluate("max(5,5;0;4;)"), 5,5);
        }

        [TestMethod()]
        public void EvaluateTest11()
        {
            Assert.AreEqual(Calculator.Evaluate("max(+100;--1000;1;0)"), 1000);
        }

        [TestMethod()]
        public void EvaluateTest12()
        {
            Assert.AreEqual(Calculator.Evaluate("min(3,14;-5,45)"), -5, 45);
        }

        [TestMethod()]
        public void EvaluateTest13()
        {
            Assert.AreEqual(Calculator.Evaluate("min(3,14;-5,45;--100)"), -5, 45);
        }

        [TestMethod()]
        public void EvaluateTest14()
        {
            Assert.AreEqual(Calculator.Evaluate("min(3,14;--5,45;--100)"), 3,14);
        }

        [TestMethod()]
        public void EvaluateTest15()
        {
            Assert.AreEqual(Calculator.Evaluate("mmax(3,14;-5,45;2,3)"), 3, 14);
        }

        [TestMethod()]
        public void EvaluateTest16()
        {
            Assert.AreEqual(Calculator.Evaluate("mmax(3,14;--5,45;2,3)"), 5,45);
        }

        [TestMethod()]
        public void EvaluateTest17()
        {
            Assert.AreEqual(Calculator.Evaluate("mmin(3,14;-5,45;2,3)"), -5, 45);
        }

        [TestMethod()]
        public void EvaluateTest18()
        {
            Assert.AreEqual(Calculator.Evaluate("mmin(3,14;--5,45;2,3)"), 2,3);
        }

        [TestMethod()]
        public void EvaluateTest19()
        {
            Assert.AreEqual(Calculator.Evaluate("mmin(3,14;-5,45;2,3) + mmax(3,14;-5,45;2,3) - max(3,14;-5,45) + 3,15^2"), 4,4725);
        }
    }
}