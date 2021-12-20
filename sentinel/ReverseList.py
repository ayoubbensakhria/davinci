# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        newHead = None
        while head:
            next = head.next
            head.next = newHead
            newHead = head
            head = next
        return newHead

#----------------------------------------------------------------
# Solution 2 - recursion
#----------------------------------------------------------------
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        return self.reverseListRecursion(head, None)
    def reverseListRecursion(self, head: Optional[ListNode], newHead: Optional[ListNode]) -> Optional[ListNode]:
        if not head:
            return newHead
        next = head.next
        head.next = newHead
        return self.reverseListRecursion (next, head)