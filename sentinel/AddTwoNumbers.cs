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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // construct the sum terms
        // get the sum
        // get the rest (carry)
        // insert the appropriate val to the appropriate node in result 
        // initialize result, terms and sum
        ListNode sentinel = new ListNode(0);
        ListNode result = sentinel;
        int rest = 0;
        
        while (l1 != null || l2 !=null || rest>0){
            
            int a = (l1 != null) ? l1.val : 0;
            int b = (l2 != null) ? l2.val : 0;   
            
            int sum = a + b + rest;               
            rest = sum / 10;  // <- returns 0 if < 10, (1, 2, ...) o.w            
            // we return result.next to avoid 
            // many if statments
            result.next = new ListNode(sum%10);      
            result = result.next;
            
            if(l1 !=null) l1 = l1.next;
            if(l2 !=null) l2 = l2.next;
        }
        return sentinel.next;     
    }
}