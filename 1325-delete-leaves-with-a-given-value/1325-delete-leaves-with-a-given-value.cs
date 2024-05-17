public class Solution {
    public TreeNode RemoveLeafNodes(TreeNode root, int target) {
        if (root == null)
            return null;
        
        root.left = RemoveLeafNodes(root.left, target);
        root.right = RemoveLeafNodes(root.right, target);
        
        return IsLeaf(root) && root.val == target ? null : root;
    }

    private bool IsLeaf(TreeNode root) {
        return root.left == null && root.right == null;
    }
}