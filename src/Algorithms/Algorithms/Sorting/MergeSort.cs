using System;
using System.Collections.Generic;
using AlgorithmsExtension.Helpers;

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
                var q = (int)Math.Floor((startIndex + lastIndex) / 2.0);
                collection.MergeSortAsc(startIndex, q);
                collection.MergeSortAsc(q + 1, lastIndex);
                collection.Merge(startIndex, q, lastIndex, Functor.Less<T>());
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
                var q = (int)Math.Floor((startIndex + lastIndex) / 2.0);
                collection.MergeSortDesc(startIndex, q);
                collection.MergeSortDesc(q + 1, lastIndex);
                collection.Merge(startIndex, q, lastIndex, Functor.Greater<T>());
            }
        }

        /// <summary>
        /// Help function for MergeSort methods. Sorts two IList collections concatenated to one if each is internally sorted
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Index of the first element of first collection</param>
        /// <param name="middleIndex">Index of the last element of first collection</param>
        /// <param name="lastIndex">Index of the last element of second collection</param>
        /// <param name="equationOperator">For ascending sort use Functor.Less, else use Functor.Greater</param>
        public static void Merge<T>(this IList<T> collection, int startIndex, int middleIndex, int lastIndex, Func<T, T, bool> equationOperator) 
            where T : IComparable, IComparable<T>
        {
            var left = CreateLefArray(collection, startIndex, CalculateLeftLength(startIndex, middleIndex));
            var right = CreateRightArray(collection, middleIndex, CalculateRightLength(middleIndex, lastIndex));

            var leftIterator = 0;
            var rightIterator = 0;

            for (int k = startIndex; k <= lastIndex; k++)
            {
                if (rightIterator >= right.Count || leftIterator < left.Count && equationOperator(left[leftIterator], right[rightIterator]))
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
