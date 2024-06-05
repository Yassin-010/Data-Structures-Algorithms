using System;
using System.Collections.Generic;

public class Solution {
    public IList<string> CommonChars(string[] A) {
        List<string> ans = new List<string>();
        int[] commonCount = new int[26];
        Array.Fill(commonCount, int.MaxValue);

        foreach (string a in A) {
            int[] count = new int[26];
            foreach (char c in a.ToCharArray())
                ++count[c - 'a'];
            for (int i = 0; i < 26; ++i)
                commonCount[i] = Math.Min(commonCount[i], count[i]);
        }

        for (char c = 'a'; c <= 'z'; ++c) {
            for (int i = 0; i < commonCount[c - 'a']; ++i)
                ans.Add(c.ToString());
        }

        return ans;
    }
}