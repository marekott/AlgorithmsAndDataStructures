using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class InsertionSort
    {
        public static void InsertionSortAsc<T>(this IList<T> collection) where T : IComparable, IComparable<T>
        {
            for (int j = 1; j < collection.Count; j++)
            {
                var key = collection[j];
                var i = j - 1;
                while (i >= 0 && collection[i].CompareTo(key) > 0)
                {
                    collection[i + 1] = collection[i];
                    i -= 1;
                }

                collection[i + 1] = key;
            }
        }

        public static void InsertionSortDesc<T>(this IList<T> collection) where T : IComparable, IComparable<T>
        {
            for (int j = 1; j < collection.Count; j++)
            {
                var key = collection[j];
                var i = j - 1;
                while (i >= 0 && collection[i].CompareTo(key) < 0)
                {
                    collection[i + 1] = collection[i];
                    i -= 1;
                }

                collection[i + 1] = key;
            }
        }
    }
}
