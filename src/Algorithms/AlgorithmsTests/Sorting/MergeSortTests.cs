using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmsExtension.Sorting;
using NUnit.Framework;

namespace AlgorithmsExtensionTests.Sorting
{
    [TestFixture]
    public class MergeSortTests
    {
        [Test]
        [Repeat(10)]
        public void MergeAscendingIntArrayTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderBy(x => x).ToArray();
            var right = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderBy(x => x).ToArray();
            var actual = new int[left.Length + right.Length];
            left.CopyTo(actual, 0);
            right.CopyTo(actual, left.Length);
            var expected = actual.OrderBy(x => x).ToArray();

            // act
            actual.MergeAsc(0,left.Length - 1, right.Length - 1 + left.Length);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeAscendingDoubleArrayTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).OrderBy(x => x).ToArray();
            var right = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).OrderBy(x => x).ToArray();
            var actual = new double[left.Length + right.Length];
            left.CopyTo(actual, 0);
            right.CopyTo(actual, left.Length);
            var expected = actual.OrderBy(x => x).ToArray();

            // act
            actual.MergeAsc(0, left.Length - 1, right.Length - 1 + left.Length);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeAscendingIntListTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderBy(x => x).ToList();
            var right = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderBy(x => x).ToList();
            var actual = left.Concat(right).ToList();
            var expected = actual.OrderBy(x => x).ToList();

            // act
            actual.MergeAsc(0, left.Count - 1, right.Count - 1 + left.Count);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeAscendingDoubleListTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).OrderBy(x => x).ToList();
            var right = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).OrderBy(x => x).ToList();
            var actual = left.Concat(right).ToList();
            var expected = actual.OrderBy(x => x).ToList();

            // act
            actual.MergeAsc(0, left.Count - 1, right.Count - 1 + left.Count);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeDescendingIntArrayTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderByDescending(x => x).ToArray();
            var right = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderByDescending(x => x).ToArray();
            var actual = new int[left.Length + right.Length];
            left.CopyTo(actual, 0);
            right.CopyTo(actual, left.Length);
            var expected = actual.OrderByDescending(x => x).ToArray();

            // act
            actual.MergeDesc(0, left.Length - 1, right.Length - 1 + left.Length);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeDescendingDoubleArrayTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).OrderByDescending(x => x).ToArray();
            var right = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).OrderByDescending(x => x).ToArray();
            var actual = new double[left.Length + right.Length];
            left.CopyTo(actual, 0);
            right.CopyTo(actual, left.Length);
            var expected = actual.OrderByDescending(x => x).ToArray();

            // act
            actual.MergeDesc(0, left.Length - 1, right.Length - 1 + left.Length);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeDescendingIntListTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderByDescending(x => x).ToList();
            var right = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderByDescending(x => x).ToList();
            var actual = left.Concat(right).ToList();
            var expected = actual.OrderByDescending(x => x).ToList();

            // act
            actual.MergeDesc(0, left.Count - 1, right.Count - 1 + left.Count);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeDescendingDoubleListTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).OrderByDescending(x => x).ToList();
            var right = Enumerable.Repeat(0, 100).Select(i => random.NextDouble()).OrderByDescending(x => x).ToList();
            var actual = left.Concat(right).ToList();
            var expected = actual.OrderByDescending(x => x).ToList();

            // act
            actual.MergeDesc(0, left.Count - 1, right.Count - 1 + left.Count);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeAscendingOddLeftHalfTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 101).Select(i => random.Next(0, 100)).OrderBy(x => x).ToArray();
            var right = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderBy(x => x).ToArray();
            var actual = new int[left.Length + right.Length];
            left.CopyTo(actual, 0);
            right.CopyTo(actual, left.Length);
            var expected = actual.OrderBy(x => x).ToArray();

            // act
            actual.MergeAsc(0, left.Length - 1, right.Length - 1 + left.Length);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeAscendingOddRightHalfTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderBy(x => x).ToArray();
            var right = Enumerable.Repeat(0, 101).Select(i => random.Next(0, 100)).OrderBy(x => x).ToArray();
            var actual = new int[left.Length + right.Length];
            left.CopyTo(actual, 0);
            right.CopyTo(actual, left.Length);
            var expected = actual.OrderBy(x => x).ToArray();

            // act
            actual.MergeAsc(0, left.Length - 1, right.Length - 1 + left.Length);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeAscendingOddBothHalvesTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 101).Select(i => random.Next(0, 100)).OrderBy(x => x).ToArray();
            var right = Enumerable.Repeat(0, 101).Select(i => random.Next(0, 100)).OrderBy(x => x).ToArray();
            var actual = new int[left.Length + right.Length];
            left.CopyTo(actual, 0);
            right.CopyTo(actual, left.Length);
            var expected = actual.OrderBy(x => x).ToArray();

            // act
            actual.MergeAsc(0, left.Length - 1, right.Length - 1 + left.Length);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeDescendingOddLeftHalfTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 101).Select(i => random.Next(0, 100)).OrderByDescending(x => x).ToArray();
            var right = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderByDescending(x => x).ToArray();
            var actual = new int[left.Length + right.Length];
            left.CopyTo(actual, 0);
            right.CopyTo(actual, left.Length);
            var expected = actual.OrderByDescending(x => x).ToArray();

            // act
            actual.MergeDesc(0, left.Length - 1, right.Length - 1 + left.Length);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeDescendingOddRightHalfTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 100).Select(i => random.Next(0, 100)).OrderByDescending(x => x).ToArray();
            var right = Enumerable.Repeat(0, 101).Select(i => random.Next(0, 100)).OrderByDescending(x => x).ToArray();
            var actual = new int[left.Length + right.Length];
            left.CopyTo(actual, 0);
            right.CopyTo(actual, left.Length);
            var expected = actual.OrderByDescending(x => x).ToArray();

            // act
            actual.MergeDesc(0, left.Length - 1, right.Length - 1 + left.Length);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Repeat(10)]
        public void MergeDescendingOddBothHalvesTest()
        {
            // arrange
            var random = new Random();
            var left = Enumerable.Repeat(0, 101).Select(i => random.Next(0, 100)).OrderByDescending(x => x).ToArray();
            var right = Enumerable.Repeat(0, 101).Select(i => random.Next(0, 100)).OrderByDescending(x => x).ToArray();
            var actual = new int[left.Length + right.Length];
            left.CopyTo(actual, 0);
            right.CopyTo(actual, left.Length);
            var expected = actual.OrderByDescending(x => x).ToArray();

            // act
            actual.MergeDesc(0, left.Length - 1, right.Length - 1 + left.Length);

            // assert
            CollectionAssert.AreEqual(expected, actual);
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
            actual.MergeSortAsc(0, actual.Length - 1);

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
            actual.MergeSortAsc(0, actual.Length - 1);

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
            actual.MergeSortAsc(0, actual.Count - 1);

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
            actual.MergeSortAsc(0, actual.Count - 1);

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
            actual.MergeSortDesc(0, actual.Length - 1);

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
            actual.MergeSortDesc(0, actual.Length - 1);

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
            actual.MergeSortDesc(0, actual.Count - 1);

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
            actual.MergeSortDesc(0, actual.Count - 1);

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
            Assert.DoesNotThrow(() => emptyList.MergeSortAsc(0, emptyList.Count));
        }

        [Test]
        public void SortDescendingEmptyList()
        {
            // arrange
            var emptyList = new List<double>();

            // act
            // assert
            Assert.DoesNotThrow(() => emptyList.MergeSortDesc(0, emptyList.Count));
        }
    }
}
