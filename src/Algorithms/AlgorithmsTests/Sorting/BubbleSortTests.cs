﻿using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Sorting;
using NUnit.Framework;

namespace AlgorithmsTests.Sorting
{
    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        [Repeat(10)]
        public void SortAscendingIntArrayTest()
        {
            // arrange
            var random = new Random();
            var actual = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).ToArray();
            var expected = new int[actual.Length];
            Array.Copy(actual, expected, actual.Length);
            expected = expected.OrderBy(x => x).ToArray();

            // act
            actual.BubbleSortAsc();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortAscendingDoubleArrayTest()
        {
            // arrange
            var random = new Random();
            var actual = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).ToArray();
            var expected = new double[actual.Length];
            Array.Copy(actual, expected, actual.Length);
            expected = expected.OrderBy(x => x).ToArray();

            // act
            actual.BubbleSortAsc();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortAscendingIntListTest()
        {
            // arrange
            var random = new Random();
            var actual = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).ToList();
            var expected = new List<int>(actual.OrderBy(x => x));

            // act
            actual.BubbleSortAsc();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortAscendingDoubleListTest()
        {
            // arrange
            var random = new Random();
            var actual = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).ToList();
            var expected = new List<double>(actual.OrderBy(x => x));

            // act
            actual.BubbleSortAsc();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortDescendingIntArrayTest()
        {
            // arrange
            var random = new Random();
            var actual = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).ToArray();
            var expected = new int[actual.Length];
            Array.Copy(actual, expected, actual.Length);
            expected = expected.OrderByDescending(x => x).ToArray();

            // act
            actual.BubbleSortDesc();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortDescendingDoubleArrayTest()
        {
            // arrange
            var random = new Random();
            var actual = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).ToArray();
            var expected = new double[actual.Length];
            Array.Copy(actual, expected, actual.Length);
            expected = expected.OrderByDescending(x => x).ToArray();

            // act
            actual.BubbleSortDesc();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortDescendingIntListTest()
        {
            // arrange
            var random = new Random();
            var actual = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).ToList();
            var expected = new List<int>(actual.OrderByDescending(x => x));

            // act
            actual.BubbleSortDesc();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortDescendingDoubleListTest()
        {
            // arrange
            var random = new Random();
            var actual = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).ToList();
            var expected = new List<double>(actual.OrderByDescending(x => x));

            // act
            actual.BubbleSortDesc();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void SortAscendingEmptyList()
        {
            // arrange
            var emptyList = new List<double>();

            // act
            // assert
            Assert.DoesNotThrow(() => emptyList.BubbleSortAsc());
        }

        [Test]
        public void SortDescendigEmptyList()
        {
            // arrange
            var emptyList = new List<double>();

            // act
            // assert
            Assert.DoesNotThrow(() => emptyList.BubbleSortDesc());
        }
    }
}
