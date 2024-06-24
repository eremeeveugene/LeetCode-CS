using LeetCode.Core.Models;

namespace LeetCode.Algorithms.FindModeInBinarySearchTree;

/// <summary>
///     https://leetcode.com/problems/find-mode-in-binary-search-tree/
/// </summary>
public interface IFindModeInBinarySearchTree
{
    int[] FindMode(TreeNode? root);
}