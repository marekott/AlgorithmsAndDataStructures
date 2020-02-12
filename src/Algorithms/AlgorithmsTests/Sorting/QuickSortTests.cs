using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmsExtension.Helpers;
using AlgorithmsExtension.Sorting;
using NUnit.Framework;

namespace AlgorithmsExtensionTests.Sorting
{
    [TestFixture]
    public class QuickSortTests
    {
        [Test]
        [Repeat(20)]
        public void PartitionAscendingProperSortTest()
        {
            // arrange
            var random = new Random();
            var actual = Enumerable.Repeat(0, 200).Select(i => random.Next(0, 200)).ToArray();

            // act
            var separatingElementIndex = actual.Partition(0, actual.Length - 1, Functor.Less<int>());

            // assert
            Assert.Multiple(() =>
            {
                for (int i = 0; i < separatingElementIndex; i++)
                {
                    Assert.LessOrEqual(actual[i], actual[separatingElementIndex]);
                }

                for (int i = separatingElementIndex + 1; i < actual.Length; i++)
                {
                    Assert.LessOrEqual(actual[separatingElementIndex], actual[i]);
                }
            });
        }

        [Test]
        [Repeat(20)]
        public void PartitionDescendingProperSortTest()
        {
            // arrange
            var random = new Random();
            var actual = Enumerable.Repeat(0, 200).Select(i => random.Next(0, 200)).ToArray();

            // act
            var separatingElementIndex = actual.Partition(0, actual.Length - 1, Functor.Greater<int>());

            // assert
            Assert.Multiple(() =>
            {
                for (int i = 0; i < separatingElementIndex; i++)
                {
                    Assert.GreaterOrEqual(actual[i], actual[separatingElementIndex]);
                }

                for (int i = separatingElementIndex + 1; i < actual.Length; i++)
                {
                    Assert.GreaterOrEqual(actual[separatingElementIndex], actual[i]);
                }
            });
        }

        [Test]
        public void PartitionAscendingProperIndexWasReturnTest()
        {
            // arrange
            var collection = new[] { 2, 8, 7, 1, 3, 5, 6, 4 };
            var expected = 3;

            // act
            var actual = collection.Partition(0, collection.Length - 1, Functor.Less<int>());

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PartitionDescendingProperIndexWasReturnTest()
        {
            // arrange
            var collection = new[] { 2, 8, 7, 1, 3, 5, 6, 4 };
            var expected = 4;

            // act
            var actual = collection.Partition(0, collection.Length - 1, Functor.Greater<int>());

            // assert
            Assert.AreEqual(expected, actual);
        }

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
            actual.QuickSortAsc(0, actual.Length - 1);

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
            actual.QuickSortAsc(0, actual.Length - 1);

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
            actual.QuickSortAsc(0, actual.Count - 1);

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
            actual.QuickSortAsc(0, actual.Count - 1);

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
            actual.QuickSortDesc(0, actual.Length - 1);

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
            actual.QuickSortDesc(0, actual.Length - 1);

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
            actual.QuickSortDesc(0, actual.Count - 1);

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
            actual.QuickSortDesc(0, actual.Count - 1);

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
            Assert.DoesNotThrow(() => emptyList.QuickSortAsc(0, emptyList.Count));
        }

        [Test]
        public void SortDescendingEmptyList()
        {
            // arrange
            var emptyList = new List<double>();

            // act
            // assert
            Assert.DoesNotThrow(() => emptyList.QuickSortDesc(0, emptyList.Count));
        }
    }
}
