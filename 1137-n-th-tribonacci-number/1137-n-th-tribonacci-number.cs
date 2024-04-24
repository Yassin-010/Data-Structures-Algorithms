public class Solution {
    public int Tribonacci(int n) {
        if (n == 0)
            return 0;
        
        int[] tribonacci = new int[Math.Max(n + 1, 3)];
        tribonacci[0] = 0;
        tribonacci[1] = 1;
        tribonacci[2] = 1;
        
        for (int i = 3; i <= n; i++) {
            tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
        }
        
        return tribonacci[n];
    }
}