using System;
using System.Collections.Generic;
using AlgorithmsExtension.Helpers;

namespace AlgorithmsExtension.Sorting
{
    public static class QuickSort
    {
        /// <summary>
        /// Sorts IList collection in ascending order using Quick sort algorithm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Index of the first element of the collection</param>
        /// <param name="lastIndex">Index of the last element of the collection</param>
        public static void QuickSortAsc<T>(this IList<T> collection, int startIndex, int lastIndex) where T : IComparable, IComparable<T>
        {
            if (startIndex < lastIndex)
            {
                var separatingElementIndex = collection.Partition(startIndex, lastIndex, Functor.Less<T>());
                collection.QuickSortAsc(startIndex, separatingElementIndex - 1);
                collection.QuickSortAsc(separatingElementIndex + 1, lastIndex);
            }
        }

        /// <summary>
        /// Sorts IList collection in descending order using Quick sort algorithm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Index of the first element of the collection</param>
        /// <param name="lastIndex">Index of the last element of the collection</param>
        public static void QuickSortDesc<T>(this IList<T> collection, int startIndex, int lastIndex) where T : IComparable, IComparable<T>
        {
            if (startIndex < lastIndex)
            {
                var separatingElementIndex = collection.Partition(startIndex, lastIndex, Functor.Greater<T>());
                collection.QuickSortDesc(startIndex, separatingElementIndex - 1);
                collection.QuickSortDesc(separatingElementIndex + 1, lastIndex);
            }
        }

        /// <summary>
        /// Help function for QuickSort methods. Collection is divided by value separating element. All values greater/lesser
        /// are moved before him and all lesser/greater after him
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Index of the first element of the collection</param>
        /// <param name="lastIndex">Index of the last element of the collection</param>
        /// <param name="equationOperator">For ascending sort use Functor.Less, else use Functor.Greater</param>
        /// <returns>Index of the element which was used to divide collection</returns>
        public static int Partition<T>(this IList<T> collection, int startIndex, int lastIndex, Func<T, T, bool> equationOperator) where T : IComparable, IComparable<T>
        {
            var separatingElement = collection[lastIndex];
            var i = startIndex - 1;

            for (int j = startIndex; j < lastIndex; j++)
            {
                if (equationOperator(collection[j], separatingElement))
                {
                    i++;
                    var temp = collection[i];
                    collection[i] = collection[j];
                    collection[j] = temp;
                }
            }

            collection[lastIndex] = collection[i + 1];
            collection[i + 1] = separatingElement;

            return i + 1;
        }
    }
}
