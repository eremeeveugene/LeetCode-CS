using LeetCode.Core.Models;

namespace LeetCode.Algorithms.LinkedListInBinaryTree;

/// <summary>
///     https://leetcode.com/problems/linked-list-in-binary-tree/
/// </summary>
public interface ILinkedListInBinaryTree
{
    bool IsSubPath(ListNode head, TreeNode root);
}