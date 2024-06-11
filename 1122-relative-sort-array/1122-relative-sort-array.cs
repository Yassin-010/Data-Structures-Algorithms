public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        int[] ans = new int[arr1.Length];
        int[] count = new int[1001];
        int i = 0;

        foreach (int a in arr1)
            ++count[a];

        foreach (int a in arr2)
        {
            while (count[a]-- > 0)
                ans[i++] = a;
        }

        for (int num = 0; num < 1001; ++num)
        {
            while (count[num]-- > 0)
                ans[i++] = num;
        }

        return ans;
    }
}