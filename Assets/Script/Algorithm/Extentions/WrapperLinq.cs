using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WrapperLinqEx
{
    public static class WrapperLinqEx
    {
        public static bool AllOf<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        {
            return enumerable.All(predicate);
        }

        public static bool AnyOf<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        {
            return enumerable.Any(predicate);
        }

        public static bool NoneOf<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        {
            return !enumerable.Any(predicate);
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable)
            {
                action(item);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, int count, Action<T> action)
        {
            int index = 0;
            foreach (var item in enumerable)
            {
                if(index >= count) break;
                action(item);
            }
        }

        public static int Count<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Count();
        }

        public static int CountIf<T>(this IEnumerable<T> enumerable, Func<T, bool> condition)
        {
            return enumerable.Where(condition).Count();
        }

        public static int Find<T>(this IEnumerable<T> enumerable, T value)
        {
            int index = 0;
            foreach (var item in enumerable)
            {
                if(item.Equals(value))
                {
                    return index;
                }
            }
            return -1;
        }

        public static int FindIf<T>(this IEnumerable<T> enumerable, Func<T, bool> prediction)
        {
            int index = 0;
            foreach (var item in enumerable)
            {
                if(prediction(item))
                {
                    return index;
                }
            }
            return -1;
        }

        public static int FindIfNot<T>(this IEnumerable<T> enumerable, Func<T, bool> prediction)
        {
            int index = 0;
            foreach (var item in enumerable)
            {
                if(!prediction(item))
                {
                    return index;
                }
            }
            return -1;
        }

        public static int Accumulate(this IEnumerable<int> enumerable, int value)
        {
            return enumerable.Sum() + value;
        }

        public static float Accumulate(this IEnumerable<float> enumerable, float value)
        {
            return enumerable.Sum() + value;
        }

        public static double Accumulate(this IEnumerable<double> enumerable, double value)
        {
            return enumerable.Sum() + value;
        }

        public static long Accumulate(this IEnumerable<long> enumerable, long value)
        {
            return enumerable.Sum() + value;
        }

        public static decimal Accumulate(this IEnumerable<decimal> enumerable, decimal value)
        {
            return enumerable.Sum() + value;
        }

        public static IEnumerable<T> Sort<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.OrderBy((x) => x, Comparer<T>.Default);
        }

        public static IEnumerable<T> Sort<T>(this IEnumerable<T> enumerable, Comparer<T> comparer)
        {
            return enumerable.OrderBy((x) => x, comparer);
        }

        public static T MinElement<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Min();
        }

        public static T MaxElement<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Max();
        }
    }    
}
