namespace LeetCode.Algorithms.MergeTwoSortedListsTask;

public class ListNode
{
    public ListNode(int value = 0, ListNode? nextNode = null)
    {
        Value = value;
        NextNode = nextNode;
    }

    public ListNode? NextNode { get; set; }
    public int Value { get; }
}