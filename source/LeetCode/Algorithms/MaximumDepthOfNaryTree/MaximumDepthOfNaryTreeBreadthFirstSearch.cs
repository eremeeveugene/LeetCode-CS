// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MaximumDepthOfNaryTreeBreadthFirstSearch : IMaximumDepthOfNaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(w), where w is the width of the tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxDepth(Node? root)
    {
        if (root == null)
        {
            return 0;
        }

        var maxDepth = 0;

        var queue = new Queue<(Node Node, int Depth)>();

        queue.Enqueue((root, 1));

        while (queue.Count > 0)
        {
            var (node, depth) = queue.Dequeue();

            maxDepth = Math.Max(maxDepth, depth);

            if (node.children == null)
            {
                continue;
            }

            foreach (var child in node.children)
            {
                queue.Enqueue((child, depth + 1));
            }
        }

        return maxDepth;
    }
}