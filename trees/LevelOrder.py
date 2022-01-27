# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        result = []
        level = collections.deque([root])
        if root is None:
            return result
        while level:
            size = len(level)
            currentNodes = []
            for _ in range (size):
                node = level.popleft()
                currentNodes.append(node.val)
                if node.left:
                    level.append(node.left)
                if node.right:
                    level.append(node.right)
            result.append(currentNodes)
        return result