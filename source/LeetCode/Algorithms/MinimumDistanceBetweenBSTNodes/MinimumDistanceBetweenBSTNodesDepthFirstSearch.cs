// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.MinimumDistanceBetweenBSTNodes;

/// <inheritdoc />
public class MinimumDistanceBetweenBSTNodesDepthFirstSearch : IMinimumDistanceBetweenBSTNodes
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Time complexity - O(n) for a skewed tree, O(log n) for a balanced tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MinDiffInBST(TreeNode root)
    {
        TreeNode? prev = null;

        return MinDiffInBST(root, ref prev, int.MaxValue);
    }

    private static int MinDiffInBST(TreeNode node, ref TreeNode? prev, int minDiff)
    {
        if (node.left != null)
        {
            minDiff = MinDiffInBST(node.left, ref prev, minDiff);
        }

        if (prev != null)
        {
            minDiff = Math.Min(minDiff, node.val - prev.val);
        }

        prev = node;

        if (node.right != null)
        {
            minDiff = MinDiffInBST(node.right, ref prev, minDiff);
        }

        return minDiff;
    }
}