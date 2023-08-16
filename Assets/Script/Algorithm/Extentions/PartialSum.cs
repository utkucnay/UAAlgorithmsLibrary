using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UA.Algorithm
{
    public static class PartialSumEx
    {
        public static IEnumerable<int> PartialSum(this IEnumerable<int> enumerable)
        {
            LinkedList<int> result = new();
            int sum = 0;

            foreach (var item in enumerable)
            {
                sum += item;
                result.AddLast(sum);
            }

            return result;
        }

        public static IEnumerable<float> PartialSum(this IEnumerable<float> enumerable)
        {
            LinkedList<float> result = new();
            float sum = 0;

            foreach (var item in enumerable)
            {
                sum += item;
                result.AddLast(sum);
            }

            return result;
        }

        public static IEnumerable<double> PartialSum(this IEnumerable<double> enumerable)
        {
            LinkedList<double> result = new();
            double sum = 0;

            foreach (var item in enumerable)
            {
                sum += item;
                result.AddLast(sum);
            }

            return result;
        }

        public static IEnumerable<long> PartialSum(this IEnumerable<long> enumerable)
        {
            LinkedList<long> result = new();
            long sum = 0;

            foreach (var item in enumerable)
            {
                sum += item;
                result.AddLast(sum);
            }

            return result;
        }

        public static IEnumerable<decimal> PartialSum(this IEnumerable<decimal> enumerable, decimal value)
        {
            LinkedList<decimal> result = new();
            decimal sum = 0;

            foreach (var item in enumerable)
            {
                sum += item;
                result.AddLast(sum);
            }

            return result;
        }
    }
}

