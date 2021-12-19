# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        result = ListNode(0)
        sentinel = result
        rest = 0
        while l1 is not None or l2 is not None or rest>0:
            a = l1.val if l1 is not None else 0
            b = l2.val if l2 is not None else 0
            sum = a + b + rest
            rest = int(sum/10)
            result.next = ListNode(sum%10)
            result = result.next
            if l1 is not None: 
                l1 = l1.next
            if l2 is not None:
                l2 = l2.next
        return sentinel.next       
        