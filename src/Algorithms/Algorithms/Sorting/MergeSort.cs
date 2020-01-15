using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class MergeSort
    {
        //TODO: testy na wszystkie sortowanie pustych kolekcji, lepsza nazwa parametrów a niektóre to można chyba wywalić i brać z obiektu na którym wołane, komentarze
        public static void MergeSortAsc<T>(this IList<T> collection, int p, int r) where T : IComparable, IComparable<T>
        {
            if (p < r)
            {
                var q = (int)Math.Floor((p + r) / 2.0);
                collection.MergeSortAsc(p, q);
                collection.MergeSortAsc(q + 1, r);
                collection.MergeAsc(p, q, r);
            }
        }

        /// <summary>
        /// Help function for MergeSortAsc. Sorts two IList collections concatenated to one if each is internally sorted ascending
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Starting index of first collection</param>
        /// <param name="middleIndex">Last index of first collection</param>
        /// <param name="lastIndex">Last index of second collection</param>
        public static void MergeAsc<T>(this IList<T> collection, int startIndex, int middleIndex, int lastIndex) where T : IComparable, IComparable<T>
        {
            var n1 = middleIndex - startIndex + 1;
            var n2 = lastIndex - middleIndex;
            IList<T> left = new T[n1];
            IList<T> right = new T[n2];

            for (int i = 0; i < n1; i++)
            {
                left[i] = collection[startIndex + i];
            }

            for (int j = 0; j < n2; j++)
            {
                right[j] = collection[middleIndex + j + 1];
            }

            var leftIterator = 0;
            var rightIterator = 0;

            for (int k = startIndex; k <= lastIndex; k++)
            {
                if (rightIterator >= right.Count || leftIterator < left.Count && left[leftIterator].CompareTo(right[rightIterator]) <= 0) 
                {
                    collection[k] = left[leftIterator];
                    leftIterator += 1;
                }
                else 
                {
                    collection[k] = right[rightIterator];
                    rightIterator += 1;
                }
            }
        }

        public static void MergeSortDesc<T>(this IList<T> collection, int p, int r) where T : IComparable, IComparable<T>
        {
            if (p < r)
            {
                var q = (int)Math.Floor((p + r) / 2.0);
                collection.MergeSortDesc(p, q);
                collection.MergeSortDesc(q + 1, r);
                collection.MergeDesc(p, q, r);
            }
        }

        /// <summary>
        /// Help function for MergeSortDesc. Sorts two IList collections concatenated to one if each is internally sorted descending
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="startIndex">Starting index of first collection</param>
        /// <param name="middleIndex">Last index of first collection</param>
        /// <param name="lastIndex">Last index of second collection</param>
        public static void MergeDesc<T>(this IList<T> collection, int startIndex, int middleIndex, int lastIndex) where T : IComparable, IComparable<T>
        {
            var n1 = middleIndex - startIndex + 1;
            var n2 = lastIndex - middleIndex;
            IList<T> left = new T[n1];
            IList<T> right = new T[n2];

            for (int i = 0; i < n1; i++)
            {
                left[i] = collection[startIndex + i];
            }

            for (int j = 0; j < n2; j++)
            {
                right[j] = collection[middleIndex + j + 1];
            }

            var z = 0;
            var y = 0;

            for (int k = startIndex; k <= lastIndex; k++)
            {
                if (y >= right.Count || z < left.Count && left[z].CompareTo(right[y]) >= 0)
                {
                    collection[k] = left[z];
                    z += 1;
                }
                else
                {
                    collection[k] = right[y];
                    y += 1;
                }
            }
        }
    }
}
