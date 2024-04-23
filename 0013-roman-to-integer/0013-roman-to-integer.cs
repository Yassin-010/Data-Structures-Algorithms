using System;
using System.Collections.Generic;

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanValues = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        int result = 0;
        int n = s.Length;

        for (int i = 0; i < n - 1; i++) {
            if (romanValues[s[i]] < romanValues[s[i + 1]]) {
                result -= romanValues[s[i]];
            }
            else {
                result += romanValues[s[i]];
            }
        }

        result += romanValues[s[n - 1]];
        return result;
    }
}