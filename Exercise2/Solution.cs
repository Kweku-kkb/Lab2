using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise2
{
    class Solution
    {
        public int solution(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int max = 0;
            int mostCommon = 0;
            var list = map.ToList();
            foreach (int i in arr)
            {
                if (map.ContainsKey(i))
                    map[i]++;
                else
                    map.Add(i, 1);
            }
            
            foreach(var item in map)
            {
                if(item.Value > max)
                {
                    max = item.Value;
                    mostCommon = item.Key;
                }
            }
            return mostCommon;
        }
    }
}
