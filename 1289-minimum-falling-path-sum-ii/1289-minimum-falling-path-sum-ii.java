class Solution {
    public int minFallingPathSum(int[][] grid) {
        int firstMin = 0; // The smallest sum of the falling path so far.
        int secondMin = 0; // The second smallest sum of the falling path so far.
        int firstMinPos = -1; // Position of the smallest sum in the previous row.
        final int INF = Integer.MAX_VALUE; // Set a high value to represent the initial state that's effectively infinity.

        // Iterating through each row in the grid.
        for (int[] row : grid) {
            int curFirstMin = INF; // The smallest sum in the current row.
            int curSecondMin = INF; // The second smallest sum in the current row.
            int curFirstMinPos = -1; // Position of the smallest sum in the current row.

            // Iterating through each element in the current row.
            for (int j = 0; j < row.length; ++j) {
                // Calculate the sum by adding the current element to the smaller of the two sums from the previous row,
                // but not the one directly above (to avoid falling path through same column, hence j != firstMinPos check).
                int sum = (j != firstMinPos ? firstMin : secondMin) + row[j];

                // If the calculated sum is smaller than the current smallest sum, update the first and second min values and positions.
                if (sum < curFirstMin) {
                    curSecondMin = curFirstMin; // The smallest becomes the second smallest.
                    curFirstMin = sum;          // The current sum becomes the new smallest.
                    curFirstMinPos = j;         // Update the current smallest sum position.
                } else if (sum < curSecondMin) { // If the current sum is between first and second min, update the second min only.
                    curSecondMin = sum;
                }
            }

            // Prepare for next row.
            firstMin = curFirstMin;
            secondMin = curSecondMin;
            firstMinPos = curFirstMinPos;
        }

        // After processing all rows, the smallest sum will represent the minimum sum of a falling path.
        return firstMin;
    }
}