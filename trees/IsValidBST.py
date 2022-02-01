# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isValidBST(self, root: Optional[TreeNode]) -> bool:
        if not root:
            return True
        previous:TreeNode = None
        stack = deque()
        while root or len(stack)>0:
            while root:
                stack.append(root)
                root = root.left
            root = stack.pop()
            if previous and root.val <= previous.val:
                return False
            previous = root
            root = root.right
        return True