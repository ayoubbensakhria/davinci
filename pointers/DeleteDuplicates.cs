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
        
        // we need a pointer to point at the head of the list, 
        // otherwise the whole list will be lost
        ListNode node = head;
        
        while(node != null && node.next != null){          
            if(node.val == node.next.val){
                // overwrite head.next with 
                // head.next.next (delete it)
                node.next = node.next.next;               
            } 
            else {
                // if different step forward
                node = node.next;
            }
        }
        // head is pointed out by node
        return head;  
    }
}