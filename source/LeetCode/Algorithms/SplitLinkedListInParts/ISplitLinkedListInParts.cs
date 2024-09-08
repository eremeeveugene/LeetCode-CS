using LeetCode.Core.Models;

namespace LeetCode.Algorithms.SplitLinkedListInParts;

/// <summary>
///     https://leetcode.com/problems/split-linked-list-in-parts/
/// </summary>
public interface ISplitLinkedListInParts
{
    ListNode?[] SplitListToParts(ListNode? head, int k);
}