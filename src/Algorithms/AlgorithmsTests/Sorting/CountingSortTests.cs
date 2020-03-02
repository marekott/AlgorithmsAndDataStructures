using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmsExtension.Sorting;
using NUnit.Framework;

namespace AlgorithmsExtensionTests.Sorting
{
    [TestFixture]
    public class CountingSortTests
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
            actual.CountingSortAsc();

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
            actual.CountingSortAsc();

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
            actual.CountingSortAsc();

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
            actual.CountingSortAsc();

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
            actual.CountingSortDesc();

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
            actual.CountingSortDesc();

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
            actual.CountingSortDesc();

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
            actual.CountingSortDesc();

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
            Assert.DoesNotThrow(() => emptyList.CountingSortAsc());
        }

        [Test]
        public void SortDescendingEmptyList()
        {
            // arrange
            var emptyList = new List<double>();

            // act
            // assert
            Assert.DoesNotThrow(() => emptyList.CountingSortDesc());
        }
    }
}
