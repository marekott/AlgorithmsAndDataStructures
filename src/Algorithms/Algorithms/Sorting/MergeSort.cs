using System;
using System.Collections.Generic;

namespace AlgorithmsExtension.Sorting
{
    public static class MergeSort
    {
        /// <summary>
        /// Sorts IList collection in ascending order using recursive divide-and-conquer algorithm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Index of the first element of the collection</param>
        /// <param name="lastIndex">Index of the last element of the collection</param>
        public static void MergeSortAsc<T>(this IList<T> collection, int startIndex, int lastIndex) where T : IComparable, IComparable<T>
        {
            if (startIndex < lastIndex)
            {
                var q = ((startIndex + lastIndex) >> 1); //equivalent of (int)Math.Floor((startIndex + lastIndex) / 2.0 but much faster
                collection.MergeSortAsc(startIndex, q);
                collection.MergeSortAsc(q + 1, lastIndex);
                collection.MergeAsc(startIndex, q, lastIndex);
            }
        }

        /// <summary>
        /// Sorts IList collection in descending order using recursive divide-and-conquer algorithm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Index of the first element of the collection</param>
        /// <param name="lastIndex">Index of the last element of the collection</param>
        public static void MergeSortDesc<T>(this IList<T> collection, int startIndex, int lastIndex) where T : IComparable, IComparable<T>
        {
            if (startIndex < lastIndex)
            {
                var q = ((startIndex + lastIndex) >> 1); //equivalent of (int)Math.Floor((startIndex + lastIndex) / 2.0 but much faster
                collection.MergeSortDesc(startIndex, q);
                collection.MergeSortDesc(q + 1, lastIndex);
                collection.MergeDesc(startIndex, q, lastIndex);
            }
        }

        /// <summary>
        /// Help function for MergeSortAsc method. Sorts two IList collections concatenated to one if each is internally sorted
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Index of the first element of first collection</param>
        /// <param name="middleIndex">Index of the last element of first collection</param>
        /// <param name="lastIndex">Index of the last element of second collection</param>
        public static void MergeAsc<T>(this IList<T> collection, int startIndex, int middleIndex, int lastIndex)
            where T : IComparable, IComparable<T>
        {
            var left = CreateLefArray(collection, startIndex, CalculateLeftLength(startIndex, middleIndex));
            var right = CreateRightArray(collection, middleIndex, CalculateRightLength(middleIndex, lastIndex));

            var leftIterator = 0;
            var rightIterator = 0;

            for (int k = startIndex; k <= lastIndex; k++)
            {
                if (rightIterator >= right.Count || leftIterator < left.Count && left[leftIterator].CompareTo(right[rightIterator]) < 0)
                {
                    collection[k] = left[leftIterator];
                    leftIterator++;
                }
                else
                {
                    collection[k] = right[rightIterator];
                    rightIterator++;
                }
            }
        }

        /// <summary>
        /// Help function for MergeSortDesc method. Sorts two IList collections concatenated to one if each is internally sorted
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Index of the first element of first collection</param>
        /// <param name="middleIndex">Index of the last element of first collection</param>
        /// <param name="lastIndex">Index of the last element of second collection</param>
        public static void MergeDesc<T>(this IList<T> collection, int startIndex, int middleIndex, int lastIndex)
            where T : IComparable, IComparable<T>
        {
            var left = CreateLefArray(collection, startIndex, CalculateLeftLength(startIndex, middleIndex));
            var right = CreateRightArray(collection, middleIndex, CalculateRightLength(middleIndex, lastIndex));

            var leftIterator = 0;
            var rightIterator = 0;

            for (int k = startIndex; k <= lastIndex; k++)
            {
                if (rightIterator >= right.Count || leftIterator < left.Count && left[leftIterator].CompareTo(right[rightIterator]) > 0)
                {
                    collection[k] = left[leftIterator];
                    leftIterator++;
                }
                else
                {
                    collection[k] = right[rightIterator];
                    rightIterator++;
                }
            }
        }

        private static int CalculateLeftLength(int startIndex, int middleIndex)
        {
            return middleIndex - startIndex + 1;
        }

        private static int CalculateRightLength(int middleIndex, int lastIndex)
        {
            return lastIndex - middleIndex;
        }

        private static IList<T> CreateLefArray<T>(IList<T> collection, int startIndex, int size)
        {
            IList<T> left = new T[size];
            for (int i = 0; i < size; i++)
            {
                left[i] = collection[startIndex + i];
            }

            return left;
        }

        private static IList<T> CreateRightArray<T>(IList<T> collection, int middleIndex, int size)
        {
            IList<T> right = new T[size];
            for (int i = 0; i < size; i++)
            {
                right[i] = collection[middleIndex + i + 1];
            }

            return right;
        }
    }
}
