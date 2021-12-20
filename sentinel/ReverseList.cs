/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        // a stack is ideal to reverse the order 
        // 1 2 3 -> 2 1 3 -> 2 3 1 -> 3 2 1
        // store next -> next = current -> store new head
        
        ListNode sentinel = null;
        
        while (head != null){
            // store next
            ListNode next = head.next;
            // now change next to new head
            head.next = sentinel;
            // store head
            sentinel = head;
            head = next;
        }
        return sentinel;             
    }
}