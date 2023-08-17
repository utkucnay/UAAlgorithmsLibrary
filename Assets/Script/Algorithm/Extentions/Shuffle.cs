using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UA.Algorithm
{
    public static class ShuffleEx 
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> values)
        {
            List<T> result = new(values);
            
            for (int i = result.Count - 2; i > 0; --i)
            {
                result.Swap(i, Random.Range(0, i + 1));
            }

            return result;
        }    
    }
}
