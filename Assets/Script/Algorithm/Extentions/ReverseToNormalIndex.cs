using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UA.Algorithm
{
    public static class ReverseToNormalIndexEx
    {
        public static int ReverseToNormalIndex<T>(this IEnumerable<T> rValues, int index)
        {
            int length = rValues.Count() - 1;
            return -index + length;
        }   
    }
}