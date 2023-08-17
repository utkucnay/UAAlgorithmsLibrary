using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UA.Algorithm
{
    public static class PrevPermutationEx 
    {
        public static bool PrevPermutation<T>(this IEnumerable<T> values, out IEnumerable<T> oResult, Comparer<T> comparer)
        {
            var result = new List<T>(values);
            int first = 0;
            int last = result.Count;

            oResult = null;

            if(first == last)
                return false;
            int i = last;
            if(first == --i)
                return false;
            
            while(true)
            {
                int i1, i2;

                i1 = i;
                if(comparer.Compare(result[i1], result[--i]) < 0)
                {
                    i2 = last;
                    while(comparer.Compare(result[i2], result[i]) < 0);
                    result.Swap(i1, i2);
                    result.Reverse(i1, last - i1);
                    oResult = result;
                    return true;
                }
                else
                {
                    result.Reverse(first, last);
                    oResult = result;
                    return false;
                }
            }

        }
    }
}
