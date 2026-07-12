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

namespace LeetCode.Algorithms.HeightOfBinaryTreeAfterSubtreeRemovalQueries;

/// <inheritdoc />
public sealed class HeightOfBinaryTreeAfterSubtreeRemovalQueriesDepthFirstSearch : IHeightOfBinaryTreeAfterSubtreeRemovalQueries
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m), where n is the number of nodes and m is the number of queries
    ///     Space complexity - O(n), where n is the number of nodes
    /// </remarks>
    public int[] TreeQueries(TreeNode root, int[] queries)
    {
        var nodesCount = GetNodesCount(root);

        Span<int> heights = stackalloc int[nodesCount + 1];

        LeftToRight(root, heights);

        RightToLeft(root, heights);

        return GetAnswer(queries, heights);
    }

    /// <summary>
    ///     Traverses the tree left to right, recording for each node the maximum height of the tree using only nodes
    ///     visited before it.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <param name="heights">The span, indexed by node value, that accumulates the heights.</param>
    /// <remarks>
    ///     Time complexity - O(n), where n is the number of nodes
    ///     Space complexity - O(n), where n is the number of nodes
    /// </remarks>
    private static void LeftToRight(TreeNode root, Span<int> heights)
    {
        var maxHeight = 0;

        var nodesStack = new Stack<(TreeNode Node, int CurrentHeight)>();

        nodesStack.Push((root, -1));

        while (nodesStack.Count > 0)
        {
            var (node, currentHeight) = nodesStack.Pop();

            var nodeValue = node.val;

            heights[nodeValue] = Math.Max(Math.Max(maxHeight, currentHeight), heights[nodeValue]);

            var nextHeight = currentHeight + 1;

            maxHeight = Math.Max(maxHeight, nextHeight);

            var rightNode = node.right;

            if (rightNode != null)
            {
                nodesStack.Push((rightNode, nextHeight));
            }

            var leftNode = node.left;

            if (leftNode != null)
            {
                nodesStack.Push((leftNode, nextHeight));
            }
        }
    }

    /// <summary>
    ///     Traverses the tree right to left, recording for each node the maximum height of the tree using only nodes
    ///     visited before it.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <param name="heights">The span, indexed by node value, that accumulates the heights.</param>
    /// <remarks>
    ///     Time complexity - O(n), where n is the number of nodes
    ///     Space complexity - O(n), where n is the number of nodes
    /// </remarks>
    private static void RightToLeft(TreeNode root, Span<int> heights)
    {
        var maxHeight = 0;

        var nodesStack = new Stack<(TreeNode Node, int CurrentHeight)>();

        nodesStack.Push((root, -1));

        while (nodesStack.Count > 0)
        {
            var (node, currentHeight) = nodesStack.Pop();

            var nodeValue = node.val;

            heights[nodeValue] = Math.Max(Math.Max(maxHeight, currentHeight), heights[nodeValue]);

            var nextHeight = currentHeight + 1;

            maxHeight = Math.Max(maxHeight, nextHeight);

            var leftNode = node.left;

            if (leftNode != null)
            {
                nodesStack.Push((leftNode, nextHeight));
            }

            var rightNode = node.right;

            if (rightNode != null)
            {
                nodesStack.Push((rightNode, nextHeight));
            }
        }
    }

    /// <summary>
    ///     Counts the nodes of the tree rooted at <paramref name="root" /> using Morris traversal.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <returns>The number of nodes in the tree.</returns>
    /// <remarks>
    ///     Time complexity - O(n), where n is the number of nodes
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetNodesCount(TreeNode? root)
    {
        var nodesCount = 0;

        var current = root;

        while (current != null)
        {
            if (current.left == null)
            {
                nodesCount++;

                current = current.right;
            }
            else
            {
                var previous = current.left;

                while (previous.right != null && previous.right != current)
                {
                    previous = previous.right;
                }

                if (previous.right == null)
                {
                    previous.right = current;

                    current = current.left;
                }
                else
                {
                    previous.right = null;

                    nodesCount++;

                    current = current.right;
                }
            }
        }

        return nodesCount;
    }

    /// <summary>
    ///     Replaces each query with the precomputed height of the tree after removing the queried subtree.
    /// </summary>
    /// <param name="queries">The queried node values, overwritten in place with the answers.</param>
    /// <param name="heights">The precomputed heights, indexed by node value.</param>
    /// <returns>The array of answers to the queries.</returns>
    /// <remarks>
    ///     Time complexity - O(m), where m is the number of queries
    ///     Space complexity - O(1)
    /// </remarks>
    private static int[] GetAnswer(int[] queries, ReadOnlySpan<int> heights)
    {
        var queriesLength = queries.Length;

        for (var i = 0; i < queriesLength; i++)
        {
            var query = queries[i];

            queries[i] = heights[query];
        }

        return queries;
    }
}