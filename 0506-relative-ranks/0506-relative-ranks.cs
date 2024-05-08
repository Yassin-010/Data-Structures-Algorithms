public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        int[] sortedScore = (int[])score.Clone();
        Array.Sort(sortedScore, (a, b) => b - a);
        
        string[] result = new string[score.Length];
        
        for (int i = 0; i < score.Length; i++) {
            int placement = Array.IndexOf(sortedScore, score[i]);
            
            if (placement == 0) {
                result[i] = "Gold Medal";
            } else if (placement == 1) {
                result[i] = "Silver Medal";
            } else if (placement == 2) {
                result[i] = "Bronze Medal";
            } else {
                result[i] = (placement + 1).ToString();
            }
        }
        
        return result;
    }
}