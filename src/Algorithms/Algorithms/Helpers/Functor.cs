using System;

namespace AlgorithmsExtension.Helpers
{
    public static class Functor
    {
        public static Func<T, T, bool> Greater<T>() where T : IComparable, IComparable<T>
        {
            return (lhs, rhs) => lhs.CompareTo(rhs) > 0;
        }

        public static Func<T, T, bool> Less<T>() where T : IComparable, IComparable<T>
        {
            return (lhs, rhs) => lhs.CompareTo(rhs) < 0;
        }
    }
}
