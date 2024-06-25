public class Solution {
    private int prefix = 0;

    public TreeNode BstToGst(TreeNode root) {
        ReverseInorder(root);
        return root;
    }

    private void ReverseInorder(TreeNode root) {
        if (root == null)
            return;

        ReverseInorder(root.right);

        root.val += prefix;
        prefix = root.val;

        ReverseInorder(root.left);
    }
}