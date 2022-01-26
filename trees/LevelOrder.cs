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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        // we will store result in result list
        var result = new List<IList<int>>();
        Queue<TreeNode> level = new Queue<TreeNode>();
        // take the tree from a particular level starting by root 
        level.Enqueue(root);
        // null case
        if(root == null) 
            return result;
        
        while(level.Count>0){
            int size = level.Count;
            var currentNodes = new List<int>();
            for(int i=0; i<size; i++){
                var node = level.Dequeue();
                currentNodes.Add(node.val);
                if(node.left != null) 
                    level.Enqueue(node.left);
                if(node.right != null) 
                    level.Enqueue(node.right);        
            }
            result.Add(currentNodes);
        }
        return result;
    }
}