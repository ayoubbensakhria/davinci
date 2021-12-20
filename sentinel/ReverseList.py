# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        sentinel = None
        while head:
            next = head.next
            head.next = sentinel
            sentinel = head
            head = next
        return sentinel