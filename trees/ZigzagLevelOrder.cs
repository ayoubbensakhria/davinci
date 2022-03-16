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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> order = new List<IList<int>>();
        // return an empty list if root is null
        if (root == null) return order;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        // add root
        queue.Enqueue(root);
        bool zigzag = false;
        while(queue.Any()){
            List<int> level = new List<int>();
            int q_size = queue.Count();
            for (int i=0; i< q_size; i++){
                TreeNode node = queue.Dequeue();
                if(zigzag){
                    level.Insert(0, node.val);
                } else {
                    level.Add(node.val);
                }
                // add left node and right node if not null
                if(node.left != null){
                    queue.Enqueue(node.left);
                } 
                if(node.right !=null){
                    queue.Enqueue(node.right);
                }
            }
            order.Add(level);
            zigzag = !zigzag;
        }
        return order;        
    }
}