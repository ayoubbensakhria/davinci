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
    public int MaxDepth(TreeNode root) {
        // Binary tree
        // DFS - Recursion problem
        if(root == null) return 0;
        // else the minimum depth is 1
        return 1 + Math.Max(MaxDepth(root.right), MaxDepth(root.left));
    }
}