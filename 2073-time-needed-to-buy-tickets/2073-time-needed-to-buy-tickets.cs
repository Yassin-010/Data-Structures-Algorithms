public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int n = tickets.Length;
        int time = 0;
        
        while (tickets[k] > 0) {
            for (int i = 0; i < n; i++) {
                if (tickets[i] > 0) {
                    tickets[i]--;
                    time++;
                    if (i == k && tickets[i] == 0)
                        return time;
                }
            }
        }
        
        return time;
    }
}