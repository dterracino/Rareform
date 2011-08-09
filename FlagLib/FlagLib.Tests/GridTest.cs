﻿using System;
using FlagLib.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlagLib.Tests
{
    /// <summary>
    ///This is a test class for GridTest and is intended
    ///to contain all GridTest Unit Tests
    ///</summary>
    [TestClass]
    public class GridTest
    {
        [TestMethod]
        public void GridConstructorTest()
        {
            int rows = 5;
            int columns = 10;

            Grid<GenericParameterHelper> target = new Grid<GenericParameterHelper>(rows, columns);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GridConstructorZeroRowsTest()
        {
            int rows = 0;
            int columns = 10;

            Grid<GenericParameterHelper> target = new Grid<GenericParameterHelper>(rows, columns);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GridConstructorZeroColumnsTest()
        {
            int rows = 5;
            int columns = 0;

            Grid<GenericParameterHelper> target = new Grid<GenericParameterHelper>(rows, columns);
        }

        [TestMethod]
        public void GridConstructorValueTypeTest()
        {
            int rows = 5;
            int columns = 10;

            Grid<int> target = new Grid<int>(rows, columns);

            foreach (int value in target)
            {
                Assert.AreEqual(0, value);
            }
        }

        [TestMethod]
        public void GridConstructorReferenceTypeTest()
        {
            int rows = 5;
            int columns = 10;

            Grid<string> target = new Grid<string>(rows, columns);

            foreach (string value in target)
            {
                Assert.AreEqual(null, value);
            }
        }

        [TestMethod]
        public void CellCountTest()
        {
            int rows = 5;
            int columns = 10;
            Grid<GenericParameterHelper> target = new Grid<GenericParameterHelper>(rows, columns);

            int expected = 50;
            int actual = target.CellCount;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ColumnCountTest()
        {
            int rows = 5;
            int columns = 10;
            Grid<GenericParameterHelper> target = new Grid<GenericParameterHelper>(rows, columns);

            int expected = 10;
            int actual = target.ColumnCount;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RowCountTest()
        {
            int rows = 5;
            int columns = 10;
            Grid<GenericParameterHelper> target = new Grid<GenericParameterHelper>(rows, columns);

            int expected = 5;
            int actual = target.RowCount;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ItemTest()
        {
            int rows = 5;
            int columns = 10;

            Grid<int> target = new Grid<int>(rows, columns);

            int row = 3;
            int column = 3;

            int expected = 25;
            int actual;

            target[row, column] = expected;
            actual = target[row, column];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ItemTest1()
        {
            int rows = 5;
            int columns = 10;

            Grid<int> target = new Grid<int>(rows, columns);

            int cell = 9;

            int expected = 25;
            int actual;

            target[cell] = expected;
            actual = target[cell];

            Assert.AreEqual(expected, actual);
        }
    }
}