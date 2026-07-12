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

namespace LeetCode.Algorithms.MaximumDepthOfNaryTree;

/// <inheritdoc />
public sealed class MaximumDepthOfNaryTreeDepthFirstSearchStack : IMaximumDepthOfNaryTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h), where h is the height of the tree
    /// </remarks>
    public int MaxDepth(Node? root)
    {
        if (root == null)
        {
            return 0;
        }

        var maxDepth = 0;

        var stack = new Stack<(Node Node, int Depth)>();

        stack.Push((root, 1));

        while (stack.Count > 0)
        {
            var (node, depth) = stack.Pop();

            maxDepth = Math.Max(maxDepth, depth);

            if (node.children == null)
            {
                continue;
            }

            foreach (var childNode in node.children)
            {
                stack.Push((childNode, depth + 1));
            }
        }

        return maxDepth;
    }
}