using System;
using System.Collections.Generic;

public class Solution
{
    public int CountTriplets(int[] arr)
    {
        int ans = 0;
        List<int> xors = new List<int>();
        int prefix = 0;

        xors.Add(0);

        for (int i = 0; i < arr.Length; i++)
        {
            int a = arr[i];
            prefix ^= a;
            xors.Add(prefix);
        }

        for (int j = 1; j < arr.Length; j++)
        {
            for (int i = 0; i < j; i++)
            {
                int xors_i = xors[j] ^ xors[i];

                for (int k = j; k < arr.Length; k++)
                {
                    int xors_k = xors[k + 1] ^ xors[j];

                    if (xors_i == xors_k)
                    {
                        ans += 1;
                    }
                }
            }
        }

        return ans;
    }
}