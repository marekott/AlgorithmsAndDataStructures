using System;
using System.Collections.Generic;
using AlgorithmsExtension.Helpers;

namespace AlgorithmsExtension.Sorting
{
    public static class BubbleSort
    {
        /// <summary>
        /// Sorts IList collection in ascending order using bubble sort algorithm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        public static void BubbleSortAsc<T>(this IList<T> collection) where T : IComparable, IComparable<T>
        {
            collection.BaseBubbleSort(Functor.Less<T>());
        }

        /// <summary>
        /// Sorts IList collection in descending order using bubble sort algorithm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        public static void BubbleSortDesc<T>(this IList<T> collection) where T : IComparable, IComparable<T>
        {
            collection.BaseBubbleSort(Functor.Greater<T>());
        }

        /// <summary>
        /// Help method for BubbleSortAsc and BubbleSortDesc. Performs actual sorting.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="equationOperator">For ascending sort use Functor.Less else use Functor.Greater</param>
        private static void BaseBubbleSort<T>(this IList<T> collection, Func<T, T, bool> equationOperator) where T : IComparable, IComparable<T>
        {
            for (int i = 0; i < collection.Count; i++)
            {
                for (int j = collection.Count - 1; j > i; j--)
                {
                    if (equationOperator(collection[j], collection[j - 1]))
                    {
                        var temp = collection[j];
                        collection[j] = collection[j - 1];
                        collection[j - 1] = temp;
                    }
                }
            }
        }
    }
}
