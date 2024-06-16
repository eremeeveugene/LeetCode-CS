using LeetCode.Core.Models;

namespace LeetCode.Algorithms.RemoveLinkedListElements;

/// <inheritdoc />
public class RemoveLinkedListElementsRecursive : IRemoveLinkedListElements
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="head"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public ListNode? RemoveElements(ListNode? head, int val)
    {
        if (head == null)
        {
            return null;
        }

        head.next = RemoveElements(head.next, val);

        return head.val == val ? head.next : head;
    }
}