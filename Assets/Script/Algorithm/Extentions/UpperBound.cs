using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UA.Algorithm
{
    public static class UpperBoundEx
    {
        public static int UpperBound<T>(this IEnumerable<T> values, T comp, Comparer<T> comparer)
        {
            int index = 0;
            foreach (var value in values)
            {
                if(comparer.Compare(comp, value) < 0)
                {
                    return index;
                }

                index++;
            }
            return index;
        }

        public static int UpperBound<T>(this IEnumerable<T> values, T comp, int endIndex, Comparer<T> comparer)
        {
            int index = 0;
            foreach (var value in values)
            {
                if(index > endIndex)
                {
                    break;    
                }
                if(comparer.Compare(comp, value) < 0)
                {
                    return index;
                }
                index++;
            }
            return index;
        }

        public static int UpperBound<T>(this IEnumerable<T> values, int beginIndex, int endIndex, T comp, Comparer<T> comparer)
        {
            int index = 0;
            foreach (var value in values)
            {
                if(index < beginIndex)
                {
                    continue;
                }
                if(index > endIndex)
                {
                    break;    
                }
                if(comparer.Compare(comp, value) < 0)
                {
                    return index;
                }
                index++;
            }
            return index;
        }
    } 
}