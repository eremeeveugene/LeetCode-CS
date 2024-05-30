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

namespace LeetCode.Algorithms.CountCompleteTreeNodes;

/// <inheritdoc />
public class CountCompleteTreeNodesDepthRecursive : ICountCompleteTreeNodes
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(log n) for a balanced tree, O(n) for a skewed tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int CountNodes(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var leftDepth = GetDepth(root, true);
        var rightDepth = GetDepth(root, false);

        if (leftDepth == rightDepth)
        {
            return (1 << leftDepth) - 1;
        }

        return CountNodes(root.left) + CountNodes(root.right) + 1;
    }

    private static int GetDepth(TreeNode? node, bool left)
    {
        var depth = 0;

        while (node != null)
        {
            depth++;

            node = left ? node.left : node.right;
        }

        return depth;
    }
}