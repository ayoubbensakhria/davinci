/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null) return false;
        // if we reach the END and root.val is the rest targetSum then return true
        if(root.left == null && root.right == null && root.val == targetSum) return true;
        // Decriment target sum by root.val till reaching the cond root.val == targetSum
        targetSum -= root.val;
        // return true if recursion is true from the left or the right
        return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
        
    }
}