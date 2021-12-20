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
        // principle reverse pointing
        // 1->2->3->null ::: newHead = null | head = 1->2->3->null:
        // store next (2->3->null), cut head (null<-1) take head newHead (null<-1) update head with next (2->3->null)
        // (newHead) null<-1  (head) 2->3->null 
        // store next (3->null), cut head (null<-2) take head newHead (null<-1<-2) update head (3->null)
        // null<-1<-2  3->null 
        // store next (null), cut head (null<-3) take head newHead (null<-1<-2<-3) update head (null)
        // null<-1<-2<-3    
        ListNode newHead = null;
        
        while (head != null){
            // store next to detach it
            ListNode next = head.next;
            // reverse pointer to newHead
            head.next = newHead; // first null detach head
            // store head
            newHead = head;
            head = next;
        }
        return sentinel;             
    }
}