using System;
using System.Collections.Generic;

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
                var separatingElementIndex = collection.PartitionAsc(startIndex, lastIndex);
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
                var separatingElementIndex = collection.PartitionDesc(startIndex, lastIndex);
                collection.QuickSortDesc(startIndex, separatingElementIndex);
                startIndex = separatingElementIndex + 1;
            }
        }

        /// <summary>
        /// Helper function for QuickSortAsc method. Collection is divided by value separating element. All values greater
        /// are moved before him and all lesser after him
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Index of the first element of the collection</param>
        /// <param name="lastIndex">Index of the last element of the collection</param>
        /// <returns></returns>
        private static int PartitionAsc<T>(this IList<T> collection, int startIndex, int lastIndex) where T : IComparable, IComparable<T>
        {
            var elementToCompare = collection[(startIndex + lastIndex) >> 1]; //equivalent of (int)Math.Floor((startIndex + lastIndex) / 2.0 but much faster
            var left = startIndex;
            var right = lastIndex;

            while (true)
            {
                while (collection[left].CompareTo(elementToCompare) < 0) left++;
                while (collection[right].CompareTo(elementToCompare) > 0) right--;

                if (left >= right)
                {
                    return right;
                }

                collection.Swap(left, right);
                left++; right--;
            }
        }

        /// <summary>
        /// Helper function for QuickSort methods. Collection is divided by value separating element. All values lesser
        /// are moved before him and all greater after him
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Index of the first element of the collection</param>
        /// <param name="lastIndex">Index of the last element of the collection</param>
        /// <returns></returns>
        private static int PartitionDesc<T>(this IList<T> collection, int startIndex, int lastIndex) where T : IComparable, IComparable<T>
        {
            var elementToCompare = collection[(startIndex + lastIndex) >> 1]; //equivalent of (int)Math.Floor((startIndex + lastIndex) / 2.0 but much faster
            var left = startIndex;
            var right = lastIndex;

            while (true)
            {
                while (collection[left].CompareTo(elementToCompare) > 0) left++;
                while (collection[right].CompareTo(elementToCompare) < 0) right--;

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
