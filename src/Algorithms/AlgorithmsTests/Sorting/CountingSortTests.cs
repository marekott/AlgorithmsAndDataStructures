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
        public void UseForDebuggingTest()
        {
            // arrange
            uint[] dataToSort = {2, 5, 3, 0, 2, 3, 0, 3 };
            var expected = new uint[dataToSort.Length];
            Array.Copy(dataToSort, expected, dataToSort.Length);
            expected = expected.OrderBy(x => x).ToArray();

            // act
            var actual = dataToSort.CountingSortAsc(dataToSort.Max());

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortAscendingUintArrayTest()
        {
            // arrange
            var random = new Random();
            var dataToSort = Enumerable.Repeat(0, 100).Select(i => (uint)random.Next(0, 100)).ToArray();
            var expected = new uint[dataToSort.Length];
            Array.Copy(dataToSort, expected, dataToSort.Length);
            expected = expected.OrderBy(x => x).ToArray();

            // act
            var actual = dataToSort.CountingSortAsc(dataToSort.Max());

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortAscendingUlongArrayTest()
        {
            // arrange
            var random = new Random();
            var dataToSort = Enumerable.Repeat(0, 100).Select(i => (ulong)random.Next(0, 100)).ToArray();
            var expected = new ulong[dataToSort.Length];
            Array.Copy(dataToSort, expected, dataToSort.Length);
            expected = expected.OrderBy(x => x).ToArray();

            // act
            var actual = dataToSort.CountingSortAsc(dataToSort.Max());

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortAscendingUintListTest()
        {
            // arrange
            var random = new Random();
            var dataToSort = Enumerable.Repeat(0, 100).Select(i => (uint)random.Next(0, 100)).ToList();
            var expected = new List<uint>(dataToSort.OrderBy(x => x));

            // act
            var actual = dataToSort.CountingSortAsc(dataToSort.Max());

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortAscendingUlongListTest()
        {
            // arrange
            var random = new Random();
            var dataToSort = Enumerable.Repeat(0, 100).Select(i => (ulong)random.Next(0, 100)).ToList();
            var expected = new List<ulong>(dataToSort.OrderBy(x => x));

            // act
            var actual = dataToSort.CountingSortAsc(dataToSort.Max());

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortDescendingUintArrayTest()
        {
            // arrange
            var random = new Random();
            var dataToSort = Enumerable.Repeat(0, 100).Select(i => (uint)random.Next(0, 100)).ToArray();
            var expected = new uint[dataToSort.Length];
            Array.Copy(dataToSort, expected, dataToSort.Length);
            expected = expected.OrderBy(x => x).ToArray();

            // act
            var actual = dataToSort.CountingSortDesc(dataToSort.Max());

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortDescendingUlongArrayTest()
        {
            // arrange
            var random = new Random();
            var dataToSort = Enumerable.Repeat(0, 100).Select(i => (ulong)random.Next(0, 100)).ToArray();
            var expected = new ulong[dataToSort.Length];
            Array.Copy(dataToSort, expected, dataToSort.Length);
            expected = expected.OrderBy(x => x).ToArray();

            // act
            var actual = dataToSort.CountingSortDesc(dataToSort.Max());

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortDescendingUintListTest()
        {
            // arrange
            var random = new Random();
            var dataToSort = Enumerable.Repeat(0, 100).Select(i => (uint)random.Next(0, 100)).ToList();
            var expected = new List<uint>(dataToSort.OrderBy(x => x));

            // act
            var actual = dataToSort.CountingSortDesc(dataToSort.Max());

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void SortDescendingUlongListTest()
        {
            // arrange
            var random = new Random();
            var dataToSort = Enumerable.Repeat(0, 100).Select(i => (ulong)random.Next(0, 100)).ToList();
            var expected = new List<ulong>(dataToSort.OrderBy(x => x));

            // act
            var actual = dataToSort.CountingSortDesc(dataToSort.Max());

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
