using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UA.Algorithm
{
    public static class NextPermutationEx
    {
        public static IEnumerable<T> NextPermutation<T>(this IEnumerable<T> values)
        {
            List<T> result = new(values);

            var rValues = values.Reverse();
            var left = -rValues.IsSortedUntil(Comparer<T>.Default) + result.Count - 1;

            if(0 != left)
            {
                var right = rValues.UpperBound(result[left], Comparer<T>.Default);
                
            }
            
            return result;
        }
    } 
}
