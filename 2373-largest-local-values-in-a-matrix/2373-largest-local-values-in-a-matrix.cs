public class Solution
{
    public int[][] LargestLocal(int[][] grid)
    {
        int n = grid.Length;
        int[][] ans = new int[n - 2][];

        for (int i = 0; i < n - 2; ++i)
        {
            ans[i] = new int[n - 2];
            for (int j = 0; j < n - 2; ++j)
            {
                for (int x = i; x < i + 3; ++x)
                {
                    for (int y = j; y < j + 3; ++y)
                    {
                        ans[i][j] = Math.Max(ans[i][j], grid[x][y]);
                    }
                }
            }
        }

        return ans;
    }
}