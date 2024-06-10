public class Solution {
public int HeightChecker(int[] heights) {
int ans = 0;
int currentHeight = 1;
int[] count = new int[101];

    foreach (int height in heights)
        ++count[height];

    foreach (int height in heights) {
        while (count[currentHeight] == 0)
            ++currentHeight;
        if (height != currentHeight)
            ++ans;
        --count[currentHeight];
    }

    return ans;
}
}