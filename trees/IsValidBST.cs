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
// see InOrderTraversal for more information on how to implement this
// A standard iterative inorder traversal using stack. Hope everyone agrees with this solution.

public class Solution {
    public bool IsValidBST(TreeNode root) {
        // true for void treenodes
        if (root == null) return true;
        // initialize previous to store previous nodes
        // while traversing the tree
        TreeNode previous = null;
        // push nodes in stack
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while(root != null || stack.Any()){
            while(root != null){
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            // previous val must be smaller than root
            if(previous != null && root.val <= previous.val) return false;
            previous = root;
            root = root.right;
        }
        // if all fine
        return true;
    }
}