# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def deleteDuplicates(self, head: Optional[ListNode]) -> Optional[ListNode]:
        sentinel = ListNode(0, head)
        pred = sentinel
        while head is not None:
            if head.next is not None and head.val == head.next.val:
                while head.next is not None and head.val == head.next.val:
                    # skip duplicate list
                    head = head.next
                # skip the last duplicate
                pred.next = head.next
            else:
                # move forward
                pred = pred.next
            # move forward
            head = head.next
        return sentinel.next