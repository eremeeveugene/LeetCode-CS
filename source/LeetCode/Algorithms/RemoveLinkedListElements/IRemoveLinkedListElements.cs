using LeetCode.Core.Models;

namespace LeetCode.Algorithms.RemoveLinkedListElements;

/// <summary>
///     https://leetcode.com/problems/remove-linked-list-elements/description/
/// </summary>
public interface IRemoveLinkedListElements
{
    ListNode? RemoveElements(ListNode? head, int val);
}