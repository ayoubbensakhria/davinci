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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // two lists sorted
        // recursion 
        // Determine the base case : when a list is null the other or null
        // merge next(s) with the smallest next
        
        // base case
        if(list1 == null){
            return list2;
        }
        if(list2 == null){
            return list1;
        }
        // recursion
        if(list1.val < list2.val){
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        } else {
            list2.next = MergeTwoLists(list2.next, list1);
            return list2;
        }
        
    }
}