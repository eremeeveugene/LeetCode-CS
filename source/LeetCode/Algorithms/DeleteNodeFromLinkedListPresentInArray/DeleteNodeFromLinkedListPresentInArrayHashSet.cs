using LeetCode.Core.Models;

namespace LeetCode.Algorithms.DeleteNodeFromLinkedListPresentInArray;

/// <inheritdoc />
public class DeleteNodeFromLinkedListPresentInArrayHashSet : IDeleteNodeFromLinkedListPresentInArray
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="head"></param>
    /// <returns></returns>
    public ListNode? ModifiedList(int[] nums, ListNode? head)
    {
        if (nums.Length == 0)
        {
            return head;
        }

        var numsHashSet = new HashSet<int>(nums);

        var dummyHead = new ListNode(0, head);

        var node = dummyHead;

        while (node?.next != null)
        {
            if (numsHashSet.Contains(node.next.val))
            {
                node.next = node.next.next;
            }
            else
            {
                node = node.next;
            }
        }

        return dummyHead.next;
    }
}