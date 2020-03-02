using System.Collections.Generic;

namespace AlgorithmsExtension.Sorting
{
    public static class CountingSort
    {
        public static IList<uint> CountingSortAsc(this IList<uint> collection, uint maxValue)
        {
            var counterArray = new uint[maxValue+1];
            var collectionLength = collection.Count;
            var result = new uint[collectionLength];

            foreach (var element in collection)
            {
                counterArray[element]++;
            }

            for (int i = 1; i <= maxValue; i++)
            {
                counterArray[i] += counterArray[i - 1];
            }

            for (int i = collectionLength - 1; i >= 0; i--)
            {
                result[counterArray[collection[i]]-1] = collection[i];
                counterArray[collection[i]]--;
            }

            return result;
        }

        public static IList<ulong> CountingSortAsc(this IList<ulong> collection, ulong maxValue)
        {
            var counterArray = new ulong[maxValue + 1];
            var collectionLength = collection.Count;
            var result = new ulong[collectionLength];

            foreach (var element in collection)
            {
                counterArray[element]++;
            }

            for (ulong i = 1; i <= maxValue; i++)
            {
                counterArray[i] += counterArray[i - 1];
            }

            for (int i = collectionLength - 1; i >= 0; i--)
            {
                result[counterArray[collection[i]] - 1] = collection[i];
                counterArray[collection[i]]--;
            }

            return result;
        }

        public static IList<uint> CountingSortDesc(this IList<uint> collection, uint maxValue)
        {
            var counterArray = new uint[maxValue + 1];
            var collectionLength = collection.Count;
            var result = new uint[collectionLength];

            foreach (var element in collection)
            {
                counterArray[element]++;
            }

            for (int i = 1; i <= maxValue; i++)
            {
                counterArray[i] += counterArray[i - 1];
            }

            for (int i = 0; i <= collectionLength - 1; i++)
            {
                result[counterArray[collection[i]] - 1] = collection[i];
                counterArray[collection[i]]--;
            }

            return result;
        }

        public static IList<ulong> CountingSortDesc(this IList<ulong> collection, ulong maxValue)
        {
            var counterArray = new ulong[maxValue + 1];
            var collectionLength = collection.Count;
            var result = new ulong[collectionLength];

            foreach (var element in collection)
            {
                counterArray[element]++;
            }

            for (ulong i = 1; i <= maxValue; i++)
            {
                counterArray[i] += counterArray[i - 1];
            }

            for (int i = 0; i <= collectionLength - 1; i++)
            {
                result[counterArray[collection[i]] - 1] = collection[i];
                counterArray[collection[i]]--;
            }

            return result;
        }
    }
}
