public class Solution
{
    public bool EvaluateTree(TreeNode root)
    {
        if (root.val < 2)
            return root.val == 1;
            
        if (root.val == 2) // OR
            return EvaluateTree(root.left) || EvaluateTree(root.right);
        
        // AND
        return EvaluateTree(root.left) && EvaluateTree(root.right);
    }
}