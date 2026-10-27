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
        ListNode curr = new ListNode(0);
        ListNode res = curr;
        int carry = 0;
        while(l1 != null && l2 != null) {
            int sum = l1.val + l2.val + carry;
            carry = sum / 10;
            l1 = l1.next;
            l2 = l2.next;
            res.next = new ListNode(sum % 10);
            res = res.next;
        }

        while(l2!=null) {
            int sum = l2.val + carry;
            carry = sum / 10;
            l2 = l2.next;
            res.next = new ListNode(sum % 10);
            res = res.next;
        }

        while(l1!=null) {
            int sum = l1.val + carry;
            carry = sum / 10;
            l1 = l1.next;
            res.next = new ListNode(sum % 10);
            res = res.next;
        }

        while(carry != 0) {
            res.next = new ListNode(carry);
            res = res.next;
            carry /= 10;
        }

        return curr.next;
    }
}
