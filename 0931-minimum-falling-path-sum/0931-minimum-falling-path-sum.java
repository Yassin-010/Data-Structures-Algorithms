class Solution {
    public int minFallingPathSum(int[][] grid) {
        int rows = grid.length;
        int cols = grid[0].length;

        int[][] dp = new int[rows][cols];
        for (int i = 0; i < cols; i++) {
            dp[0][i] = grid[0][i];
        }

        for (int i = 1; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                dp[i][j] = grid[i][j] + getMin(dp, i - 1, j);
            }
        }

        int minPathSum = Integer.MAX_VALUE;
        for (int i = 0; i < cols; i++) {
            minPathSum = Math.min(minPathSum, dp[rows - 1][i]);
        }

        return minPathSum;
    }

    private int getMin(int[][] dp, int row, int col) {
        int cols = dp[0].length;
        int min = Integer.MAX_VALUE;

        for (int i = -1; i <= 1; i++) {
            int prevCol = col + i;
            if (prevCol >= 0 && prevCol < cols) {
                min = Math.min(min, dp[row][prevCol]);
            }
        }

        return min;
    }
}