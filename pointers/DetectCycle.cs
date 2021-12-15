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
    public ListNode DetectCycle(ListNode head) {
        // linked lists
        // detect cycles
        // slow and fast pointers = tortoise and hare algorithm
        ListNode slowP = head;
        ListNode fastP = head;
        // track the fast pointer
        while(fastP != null && fastP.next !=null){
            slowP = slowP.next;
            fastP = fastP.next.next;
            // meeting point confirmed
            // slowP made a + b
            // fastP a + 2b + c
            // given that distance = speed * time
            // since speed_fast = 2*speed_slow and t = constant 
            // if slow doubles the speed the distance
            // 2* (a+b) = a + 2b + c => a = c
            // so we just move the slowP and head 
            // and after c (or a) they will meet
            if(slowP == fastP) {
                // now we want to find pos of the intersection
                while(head != slowP){
                    head = head.next;
                    slowP = slowP.next;
                }
                return slowP;
            }            
        }               
        return null;
    }
}