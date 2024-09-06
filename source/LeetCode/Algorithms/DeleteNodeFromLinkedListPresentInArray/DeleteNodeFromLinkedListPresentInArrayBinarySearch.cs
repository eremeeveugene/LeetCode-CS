using LeetCode.Core.Models;

namespace LeetCode.Algorithms.DeleteNodeFromLinkedListPresentInArray;

/// <inheritdoc />
public class DeleteNodeFromLinkedListPresentInArrayBinarySearch : IDeleteNodeFromLinkedListPresentInArray
{
    /// <summary>
    ///     Time complexity - O(n log n + m log n)
    ///     Space complexity - O(1)
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

        Array.Sort(nums);

        var dummyHead = new ListNode(0, head);

        var node = dummyHead;

        while (node is { next: not null })
        {
            if (BinarySearch(nums, node.next.val))
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

    private static bool BinarySearch(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var mid = left + ((right - left) / 2);

            if (nums[mid] == target)
            {
                return true;
            }

            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}