public class Solution {
    public string ReversePrefix(string word, char ch) {
        int index = word.IndexOf(ch);
        if (index == -1) {
            return word; // ch not found, return original string
        }
        
        char[] chars = word.Substring(0, index + 1).ToCharArray();
        Array.Reverse(chars);
        
        return new string(chars) + word.Substring(index + 1);
    }
}