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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode temp = head;
        int l = 0;
        while(temp!=null) {
            l++;
            temp = temp.next;
        }

        if(l == n) {
            return head.next;
        }

        temp = head;

        for(int i=0;i<l-n-1;i++) {
            temp = temp.next;
        }

        temp.next = temp.next.next;
        return head;
    }
}
