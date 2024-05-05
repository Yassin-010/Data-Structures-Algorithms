
public class Solution {
    public void DeleteNode(ListNode node) {
        node.val = node.next.val;     // Copy the value of the next node
        node.next = node.next.next;   // Skip the next node
    }
}