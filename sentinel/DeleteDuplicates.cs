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
    public ListNode DeleteDuplicates(ListNode head) {
        // sentinel node as a traversal path terminator
        // it takes head as next node
        // the current function returns sentinel.next as duplicate free ListNode
        // |SENTINEL|--|predecessor|--|head|
        ListNode sentinel = new ListNode(0, head);
        // the predecessor = the last node
        ListNode predecessor = sentinel;
        
        while (head != null){
           if(head.next !=null && head.val == head.next.val){
               // move till the end of duplicates list
               while(head.next !=null && head.val == head.next.val ){
                   head = head.next;
               }
               // now skip the last duplicate
               predecessor.next = head.next;
           } else {
               // move forward
               predecessor = predecessor.next;               
           }
            // move forward
            head = head.next;
        }
        return sentinel.next;
    }
}