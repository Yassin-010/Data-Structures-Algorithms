public class Solution
{
    private int ans = 0;

    public int DistributeCoins(TreeNode root)
    {
        DFS(root);
        return ans;
    }

    private int DFS(TreeNode root)
    {
        if (root == null)
            return 0;

        int l = DFS(root.left);
        int r = DFS(root.right);
        ans += Math.Abs(l) + Math.Abs(r);

        return (root.val - 1) + l + r;
    }
}