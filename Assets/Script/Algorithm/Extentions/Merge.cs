using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UA.Algorithm
{
    public static class MergeEx
    {
        public static IEnumerable<T> Merge<T>(this IEnumerable<T> sorted1, IEnumerable<T> sorted2, Comparer<T> comparer)
        {
            List<T> result = new();
            var iter1 = sorted1.GetEnumerator();
            var iter2 = sorted2.GetEnumerator();

            if(!iter1.MoveNext())
            {
                return result;
            }
            if(!iter2.MoveNext())
            {
                return result;
            }

            while (true)
            {
                if(comparer.Compare(iter1.Current, iter2.Current) < 0)
                {
                    result.Add(iter1.Current);
                    if(!iter1.MoveNext())
                    {
                        result.Add(iter2.Current);
                        break;
                    }
                }
                else
                {
                    result.Add(iter2.Current);
                    if(!iter2.MoveNext())
                    {
                        result.Add(iter1.Current);
                        break;
                    }
                }
            }

            while (iter1.MoveNext())
            {
                result.Add(iter1.Current);        
            }

            while (iter2.MoveNext())
            {
                result.Add(iter2.Current);        
            }

            iter1.Dispose();
            iter2.Dispose();
            return result;
        }
    } 
}
