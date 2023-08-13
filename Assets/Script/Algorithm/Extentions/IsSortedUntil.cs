using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UA.Algorithm
{
    public static class IsSortedUntilEx
    {
        public static int IsSortedUntil<T>(this IEnumerable<T> values, Comparer<T> comparer)
        {
            int result = 0;
            var nIter = values.GetEnumerator();
            var pIter = values.GetEnumerator();

            nIter.MoveNext();
            pIter.MoveNext();
            
            while (nIter.MoveNext())
            {
                if(comparer.Compare(pIter.Current, nIter.Current) < 0)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }

            nIter.Dispose();
            pIter.Dispose();
            return result;
        }
    } 
}
