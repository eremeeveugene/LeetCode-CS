using LeetCode.Core.Models;

namespace LeetCode.Algorithms.DeleteNodeFromLinkedListPresentInArray;

/// <summary>
///     https://leetcode.com/problems/delete-nodes-from-linked-list-present-in-array/description/
/// </summary>
public interface IDeleteNodeFromLinkedListPresentInArray
{
    ListNode? ModifiedList(int[] nums, ListNode? head);
}