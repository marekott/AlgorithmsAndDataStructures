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
            while (startIndex < lastIndex)
            {
                var separatingElementIndex = collection.Partition(startIndex, lastIndex, Functor.Less<T>(), Functor.Greater<T>());
                collection.QuickSortAsc(startIndex, separatingElementIndex);
                startIndex = separatingElementIndex + 1;
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
            while (startIndex < lastIndex)
            {
                var separatingElementIndex = collection.Partition(startIndex, lastIndex, Functor.Greater<T>(), Functor.Less<T>());
                collection.QuickSortDesc(startIndex, separatingElementIndex);
                startIndex = separatingElementIndex + 1;
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
        /// <param name="leftEquationOperator">For ascending sort use Functor.Less, else use Functor.Greater</param>
        /// <param name="rightEquationOperator">For ascending sort use Functor.Greater, else use Functor.Less</param>
        /// <returns>Index of the element which was used to divide collection</returns>
        private static int Partition<T>(this IList<T> collection, int startIndex, int lastIndex, Func<T, T, bool> leftEquationOperator, 
            Func<T, T, bool> rightEquationOperator) where T : IComparable, IComparable<T>
        {
            var elementToCompare = collection[(startIndex + lastIndex) >> 1]; //equivalent of (int)Math.Floor((startIndex + lastIndex) / 2.0 but much faster
            var left = startIndex;
            var right = lastIndex;

            while (true)
            {
                while (leftEquationOperator(collection[left], elementToCompare)) left++;
                while (rightEquationOperator(collection[right], elementToCompare)) right--;

                if (left >= right)
                {
                    return right;
                }

                collection.Swap(left, right);
                left++; right--;
            }
        }

        private static void Swap<T>(this IList<T> collection, int left, int right)
        {
            var temp = collection[left];
            collection[left] = collection[right];
            collection[right] = temp;
        }
    }
}
