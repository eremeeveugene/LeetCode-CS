namespace LeetCode.Core.Models;

/// <summary>
/// Definition for singly-linked list
/// </summary>
public class ListNode
{
    public ListNode? next;
    public int val;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}