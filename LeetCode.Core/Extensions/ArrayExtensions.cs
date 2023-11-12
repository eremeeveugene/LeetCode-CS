namespace LeetCode.Core.Extensions;

public static class ArrayExtensions
{
    public static ListNode? ToListNode(this int[] array)
    {
        return array.Reverse().Aggregate<int, ListNode?>(null, (next, val) => new ListNode(val, next));
    }
}