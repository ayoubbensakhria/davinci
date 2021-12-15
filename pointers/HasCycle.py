# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:
        fastP = head
        slowP = head
        while (fastP is not None and fastP.next is not None):
            slowP = slowP.next
            fastP = fastP.next.next
        if slowP == fastP:
            return True
        return False