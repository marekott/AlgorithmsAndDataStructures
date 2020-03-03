using System.Collections.Generic;

namespace AlgorithmsExtension.Sorting
{
    public static class CountingSort
    {
        /// <summary>
        /// Sorts IList collection in ascending order using counting sort algorithm
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="maxValue">The maximum value of the sorted collection</param>
        /// <returns>New sorted IList collection</returns>
        public static IList<uint> CountingSortAsc(this IList<uint> collection, uint maxValue)
        {
            var collectionLength = collection.Count;
            var result = new uint[collectionLength];
            var counterArray = collection.CreateCounterArray(maxValue);

            for (int i = collectionLength - 1; i >= 0; i--)
            {
                result[counterArray[collection[i]]-1] = collection[i];
                counterArray[collection[i]]--;
            }

            return result;
        }

        /// <summary>
        /// Sorts IList collection in ascending order using counting sort algorithm
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="maxValue">The maximum value of the sorted collection</param>
        /// <returns>New sorted IList collection</returns>
        public static IList<ulong> CountingSortAsc(this IList<ulong> collection, ulong maxValue)
        {
            var collectionLength = collection.Count;
            var result = new ulong[collectionLength];
            var counterArray = collection.CreateCounterArray(maxValue);

            for (int i = collectionLength - 1; i >= 0; i--)
            {
                result[counterArray[collection[i]] - 1] = collection[i];
                counterArray[collection[i]]--;
            }

            return result;
        }

        /// <summary>
        /// Sorts IList collection in descending order using counting sort algorithm
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="maxValue">The maximum value of the sorted collection</param>
        /// <returns>New sorted IList collection</returns>
        public static IList<uint> CountingSortDesc(this IList<uint> collection, uint maxValue)
        {
            var collectionLength = collection.Count;
            var result = new uint[collectionLength];
            var counterArray = collection.CreateCounterArray(maxValue);

            for (int i = 0; i <= collectionLength - 1; i++)
            {
                result[counterArray[collection[i]] - 1] = collection[i];
                counterArray[collection[i]]--;
            }

            return result;
        }

        /// <summary>
        /// Sorts IList collection in descending order using counting sort algorithm
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="maxValue">The maximum value of the sorted collection</param>
        /// <returns>New sorted IList collection</returns>
        public static IList<ulong> CountingSortDesc(this IList<ulong> collection, ulong maxValue)
        {
            var collectionLength = collection.Count;
            var result = new ulong[collectionLength];
            var counterArray = collection.CreateCounterArray(maxValue);

            for (int i = 0; i <= collectionLength - 1; i++)
            {
                result[counterArray[collection[i]] - 1] = collection[i];
                counterArray[collection[i]]--;
            }

            return result;
        }

        private static uint[] CreateCounterArray(this IList<uint> collection, uint maxValue)
        {
            var counterArray = new uint[maxValue + 1];
            foreach (var element in collection)
            {
                counterArray[element]++;
            }

            counterArray.CountLesserOrEqualToNumbers(maxValue);

            return counterArray;
        }

        private static void CountLesserOrEqualToNumbers(this uint[] counterArray, uint maxValue)
        {
            for (int i = 1; i <= maxValue; i++)
            {
                counterArray[i] += counterArray[i - 1];
            }
        }

        private static ulong[] CreateCounterArray(this IList<ulong> collection, ulong maxValue)
        {
            var counterArray = new ulong[maxValue + 1];
            foreach (var element in collection)
            {
                counterArray[element]++;
            }

            counterArray.CountLesserOrEqualToNumbers(maxValue);

            return counterArray;
        }

        private static void CountLesserOrEqualToNumbers(this ulong[] counterArray, ulong maxValue)
        {
            for (ulong i = 1; i <= maxValue; i++)
            {
                counterArray[i] += counterArray[i - 1];
            }
        }
    }
}
