public class Solution {
    public int AppendCharacters(string s, string t) {
        int i = 0; // t's index

        foreach (char c in s.ToCharArray()) {
            if (c == t[i]) {
                if (++i == t.Length) {
                    return 0;
                }
            }
        }

        return t.Length - i;
    }
}