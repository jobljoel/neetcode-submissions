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
        ListNode leftCurrent = list1;
        ListNode rightCurrent = list2;
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;

        while (leftCurrent != null && rightCurrent != null) {
            if (leftCurrent.val <= rightCurrent.val) {
                current.next = leftCurrent;
                leftCurrent = leftCurrent.next;
            } else {
                current.next = rightCurrent;
                rightCurrent = rightCurrent.next;
            }
            current = current.next;
        }

        if (leftCurrent != null) {
            current.next = leftCurrent;
        } else {
            current.next = rightCurrent;
        }

        return dummy.next;
    }
}