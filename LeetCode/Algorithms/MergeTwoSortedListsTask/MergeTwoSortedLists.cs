using LeetCode.Core;

namespace LeetCode.Algorithms.MergeTwoSortedListsTask;

/// <summary>
///     Merge Two Sorted Lists
///     https://leetcode.com/problems/merge-two-sorted-lists/description/
///     You are given the heads of two sorted linked lists list1 and list2.
///     Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two
///     lists.
///     Return the head of the merged linked list.
///     Example 1:
///     Input: list1 = [1,2,4], list2 = [1,3,4]
///     Output: [1,1,2,3,4,4]
///     Example 2:
///     Input: list1 = [], list2 = []
///     Output: []
///     Example 3:
///     Input: list1 = [], list2 = [0]
///     Output: [0]
///     Constraints:
///     The number of nodes in both lists is in the range [0, 50].
///     -100 less than or equal to Node.val less than or equal to 100
///     Both list1 and list2 are sorted in non-decreasing order.
/// </summary>
public static class MergeTwoSortedLists
{
    public static ListNode? GetResult(ListNode? list1, ListNode? list2)
    {
        if (list1 == null && list2 == null) return null;

        if (list1 == null && list2 != null) return list2;

        if (list1 != null && list2 == null) return list1;

        if (list1 != null && list2 != null)
        {
            ListNode? headNode = null;

            ListNode? previousNode = null;

            while (list1 != null || list2 != null)
            {
                if (list1 == null && list2 != null)
                {
                    var list2CurrentNode = new ListNode(list2.val);

                    if (previousNode != null) previousNode.next = list2CurrentNode;

                    previousNode = list2CurrentNode;

                    headNode ??= list2CurrentNode;

                    list2 = list2.next;

                    continue;
                }

                if (list1 != null && list2 == null)
                {
                    var list1CurrentNode = new ListNode(list1.val);

                    if (previousNode != null) previousNode.next = list1CurrentNode;

                    previousNode = list1CurrentNode;

                    headNode ??= list1CurrentNode;

                    list1 = list1.next;

                    continue;
                }

                if (list1.val < list2.val)
                {
                    var list1CurrentNode = new ListNode(list1.val);

                    if (previousNode != null) previousNode.next = list1CurrentNode;

                    previousNode = list1CurrentNode;

                    headNode ??= list1CurrentNode;

                    list1 = list1.next;
                }
                else
                {
                    var list2CurrentNode = new ListNode(list2.val);

                    if (previousNode != null) previousNode.next = list2CurrentNode;

                    previousNode = list2CurrentNode;

                    headNode ??= list2CurrentNode;

                    list2 = list2.next;
                }
            }

            return headNode;
        }

        return null;
    }
}