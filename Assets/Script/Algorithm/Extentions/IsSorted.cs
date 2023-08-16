using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UA.Algorithm
{
    public static class IsSortedEx 
    {
        public static bool IsSorted<T>(IEnumerable<T> enumerable, Comparer<T> comparer)
        {
            IEnumerator<T> pIter = enumerable.GetEnumerator();
            IEnumerator<T> nIter = enumerable.GetEnumerator();
            
            nIter.MoveNext();
            pIter.MoveNext();

            while (nIter.MoveNext())
            {
                if (comparer.Compare(pIter.Current, nIter.Current) < 0) return false;
                pIter.MoveNext();
            }

            return true;
        }
    }
}