public class Solution {
    public int MyAtoi(string s) {
        int index = 0;
        int sign = 1;
        int result = 0;

        // Remove leading whitespaces
        while (index < s.Length && s[index] == ' ') {
            index++;
        }

        // Check for sign
        if (index < s.Length && (s[index] == '+' || s[index] == '-')) {
            sign = (s[index++] == '-') ? -1 : 1;
        }

        // Convert digits
        while (index < s.Length && char.IsDigit(s[index])) {
            int digit = s[index++] - '0';

            // Check for overflow
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > int.MaxValue % 10)) {
                return (sign == -1) ? int.MinValue : int.MaxValue;
            }

            result = result * 10 + digit;
        }

        return result * sign;
    }
}