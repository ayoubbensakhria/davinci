/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        // linked list
        // detect cycles
        // slow and fast pointers = tortoise and hare algorithm
        ListNode slowP = head;
        ListNode fastP = head;
        // make sure both pointers are not null
        while(fastP != null && fastP.next !=null){
            slowP = slowP.next;
            fastP = fastP.next.next;
            if(slowP == fastP) return true;
        }
        return false;      
    }
}