using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UA.Algorithm
{
    public static class IsPermutationEx
    {
        public static bool IsPermutation<T>(this IEnumerable<T> enumerator1, IEnumerable<T> enumerator2)
        {
            Dictionary<T, int> dic1 = new();
            Dictionary<T, int> dic2 = new();

            foreach (var item in enumerator1)
            {
                if(dic1.ContainsKey(item))
                    dic1[item]++;
                else
                    dic1.Add(item, 1);
            }

            foreach (var item in enumerator2)
            {
                if(dic2.ContainsKey(item))
                    dic2[item]++;
                else
                    dic2.Add(item, 1);
            }

            foreach (var item in dic1)
            {
                if(!dic2.ContainsKey(item.Key)) return false;
                
                if(item.Value != dic2[item.Key]) return false;
            }
            return true;
        }
    }
}


