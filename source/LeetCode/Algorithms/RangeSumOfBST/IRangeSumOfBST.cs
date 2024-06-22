using LeetCode.Core.Models;

namespace LeetCode.Algorithms.RangeSumOfBST;

/// <summary>
///     https://leetcode.com/problems/range-sum-of-bst/
/// </summary>
public interface IRangeSumOfBST
{
    int RangeSumBST(TreeNode? root, int low, int high);
}