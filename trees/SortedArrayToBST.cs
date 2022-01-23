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
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums.Length == 0)
            return null;
        // the middle of the array nums is the root node
        int middle = nums.Length/2;
        // get root TreeNode
        TreeNode root = new TreeNode(nums[middle]);
        // reucrsive DFS
        root.left = SortedArrayToBST(nums[..middle]);
        root.right = SortedArrayToBST(nums[(middle+1)..]);
        return root;
    }
}