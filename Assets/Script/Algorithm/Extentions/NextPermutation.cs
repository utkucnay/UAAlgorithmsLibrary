using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UA.Algorithm
{
    public static class NextPermutationEx
    {
        public static bool NextPermutation<T>(this IEnumerable<T> values, out IEnumerable<T> nextPer)
        {
            List<T> result = new(values);

            var rValues = values.Reverse();
            var rLeft = rValues.IsSortedUntil(Comparer<T>.Default);
            var left = rValues.ReverseToNormalIndex(rLeft);

            if(-1 != left)
            {
                var rRight = rValues.UpperBound(result[left], rLeft, Comparer<T>.Default);
                var right = rValues.ReverseToNormalIndex(rRight);
                result.Swap(left, right);
            }

            result.Reverse(left + 1, result.Count - 1 - left);
            nextPer = result;
            return left != -1;
        } 
    }
}
