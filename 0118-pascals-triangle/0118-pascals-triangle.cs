public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> ans = new List<IList<int>>();

        for (int i = 0; i < numRows; ++i) {
            int[] temp = new int[i + 1];
            Array.Fill(temp, 1);
            ans.Add(temp.ToList());
        }

        for (int i = 2; i < numRows; ++i) {
            for (int j = 1; j < ans[i].Count - 1; ++j) {
                ans[i][j] = ans[i - 1][j - 1] + ans[i - 1][j];
            }
        }

        return ans;
    }
}