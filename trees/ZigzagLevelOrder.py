# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
from queue import Queue

class Solution:
    def zigzagLevelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        ordered = []
        # return an empty list if root is null
        if root is None: return ordered
        queue = Queue()
        # add root
        queue.put(root)
        zigzag = False
        while (not queue.empty()):
            level = []
            q_size = queue.qsize()
            for i in range (q_size):
                node = queue.get()
                if zigzag:
                    level.insert(0, node.val)
                else:
                    level.append(node.val)
                # add left node and right node if not null
                if (node.left != None):
                    queue.put(node.left)
                if(node.right != None):
                    queue.put(node.right)
            # add this level
            ordered.append(level)
            zigzag = not zigzag
        return ordered