# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def detectCycle(self, head: ListNode) -> ListNode:
        slowP = head
        fastP = head
        while fastP is not None and fastP.next is not None:
            slowP = slowP.next
            fastP = fastP.next.next
            if(slowP == fastP):
                while slowP != head:
                    slowP = slowP.next
                    head = head.next
                return slowP
        return None