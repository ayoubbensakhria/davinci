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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        // case preorder is empty
        if(!preorder.Any() || !inorder.Any())
            return null;        
        // case preorder contains one node
        if (preorder.Count() == 1)
            return new TreeNode(preorder[0]);
        // else construct root
        TreeNode root = new TreeNode(preorder[0]);
        int root_index = Array.IndexOf(inorder, preorder[0]);
        // construct left and right recursively
        root.left = BuildTree (preorder[1..(root_index+1)], inorder[..root_index]);
        root.right = BuildTree (preorder[(root_index+1)..], inorder[(root_index+1)..]);
        // return root
        return root;    
    }
}