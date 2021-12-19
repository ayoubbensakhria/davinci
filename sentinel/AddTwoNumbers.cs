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
        // convert the sum to a linked list
        
        // initialize result, terms and sum
        ListNode result = new ListNode(0);
        ListNode sentinel = result;
        int rest = 0;
        
        while (l1 != null || l2 !=null){
            
            int a = (l1 != null) ? l1.val : 0;
            int b = (l2 != null) ? l2.val : 0;   
            
            int sum = a + b + rest;   
            
            // if sum is > 10
            if(sum >= 10){
                rest = sum/10;
                sum = 0;
            }
            
            result.val = sum;            
            result.next = new ListNode(0);
            result = result.next;
            
            l1 = l1.next;
            l2 = l2.next;
            
        }
        return sentinel;     
    }
}