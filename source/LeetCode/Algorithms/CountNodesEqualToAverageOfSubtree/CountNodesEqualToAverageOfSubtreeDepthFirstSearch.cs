// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.CountNodesEqualToAverageOfSubtree;

/// <inheritdoc />
public sealed class CountNodesEqualToAverageOfSubtreeDepthFirstSearch : ICountNodesEqualToAverageOfSubtree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h), where h is the tree height, for the recursion stack.
    /// </remarks>
    public int AverageOfSubtree(TreeNode root)
    {
        var subtreeStatistics = GetSubtreeStatistics(root);

        return subtreeStatistics.Result;
    }

    /// <summary>
    ///     Computes the subtree's value sum, node count, and number of nodes equal to their subtree average.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(n), where n is the number of nodes in the subtree.
    ///     Space complexity - O(h), where h is the subtree height, for the recursion stack.
    /// </remarks>
    /// <param name="treeNode">The root of the nonempty subtree.</param>
    /// <returns>The subtree's value sum, node count, and matching-node count.</returns>
    private static (int Sum, int Count, int Result) GetSubtreeStatistics(TreeNode treeNode)
    {
        var sum = treeNode.val;
        var nodeCount = 1;
        var result = 0;

        if (treeNode.left != null)
        {
            var leftSubtreeStatistics = GetSubtreeStatistics(treeNode.left);

            sum += leftSubtreeStatistics.Sum;
            nodeCount += leftSubtreeStatistics.Count;
            result += leftSubtreeStatistics.Result;
        }

        if (treeNode.right != null)
        {
            var rightSubtreeStatistics = GetSubtreeStatistics(treeNode.right);

            sum += rightSubtreeStatistics.Sum;
            nodeCount += rightSubtreeStatistics.Count;
            result += rightSubtreeStatistics.Result;
        }

        var average = sum / nodeCount;

        if (average == treeNode.val)
        {
            result++;
        }

        return (sum, nodeCount, result);
    }
}