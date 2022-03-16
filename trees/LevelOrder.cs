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
        var order = new List<IList<int>>();
        Queue<TreeNode> level = new Queue<TreeNode>();
        // take the tree from a particular level starting by root 
        // size(0) = 1
        level.Enqueue(root);
        // null case
        if(root == null) 
            return order;
        
        while(level.Count>0){
            int size = level.Count; // <- size(0) = 1 then 2, 4, 8, ...
            var currentNodes = new List<int>();
            for(int i=0; i<size; i++){
                // get the root
                var node = level.Dequeue();
                // get root value (int)
                currentNodes.Add(node.val);
                // get (Enqueue) children if not null (size doubles at each level)
                if(node.left != null) 
                    level.Enqueue(node.left);
                if(node.right != null) 
                    level.Enqueue(node.right);        
            }
            order.Add(currentNodes);
        }
        return order;
    }
}