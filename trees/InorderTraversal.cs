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

// A standard iterative inorder traversal using stack. Hope everyone agrees with this solution.

public class Solution {
    public bool IsValidBST(TreeNode root) {
        List<Integer> result = new ArrayList<>();
        // true for void treenodes
        if (root == null) return result;
        // push nodes in stack
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while(root != null || stack.Any()){
            while(root != null){
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            result.Add(root.val)
            root = root.right;
        }
        // if all fine
        return result;
    }
}