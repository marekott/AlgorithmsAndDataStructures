using System;
using System.Collections.Generic;
using Algorithms.Helpers;

namespace Algorithms.Sorting
{
    public static class InsertionSort
    {
        /// <summary>
        /// Sorts IList collection in ascending order using insertion sort algorithm. Optimistic case sorts in an + b time,
        /// where n - collection size, a, b - constants. Pessimistic case
        /// uses an^2 + bn +c, where n - collection size, a, b, c - constants
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        public static void InsertionSortAsc<T>(this IList<T> collection) where T : IComparable, IComparable<T>
        {
            collection.BaseInsertionSort(Functor.Greater<T>());
        }

        /// <summary>
        /// Sorts IList collection in descending order using insertion sort algorithm. Optimistic case sorts in an + b time,
        /// where n - collection size, a, b - constants. Pessimistic case
        /// uses an^2 + bn +c, where n - collection size, a, b, c - constants
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        public static void InsertionSortDesc<T>(this IList<T> collection) where T : IComparable, IComparable<T>
        {
            collection.BaseInsertionSort(Functor.Less<T>());
        }

        /// <summary>
        /// Help method for InsertionSortAsc and InsertionSortDesc. Performs actual sorting.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="equationOperator">For ascending sort use Functor.Greater else use Functor.Less</param>
        private static void BaseInsertionSort<T>(this IList<T> collection, Func<T, T, bool> equationOperator) where T : IComparable, IComparable<T>
        {
            for (int j = 1; j < collection.Count; j++)
            {
                var key = collection[j];
                var i = j - 1;
                while (i >= 0 && equationOperator(collection[i], key))
                {
                    collection[i + 1] = collection[i];
                    i -= 1;
                }

                collection[i + 1] = key;
            }
        }
    }
}
