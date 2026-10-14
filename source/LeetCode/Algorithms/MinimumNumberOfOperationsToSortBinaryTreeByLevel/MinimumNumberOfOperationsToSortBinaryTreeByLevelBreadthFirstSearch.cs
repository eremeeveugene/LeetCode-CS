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

namespace LeetCode.Algorithms.MinimumNumberOfOperationsToSortBinaryTreeByLevel;

/// <inheritdoc />
public sealed class MinimumNumberOfOperationsToSortBinaryTreeByLevelBreadthFirstSearch : IMinimumNumberOfOperationsToSortBinaryTreeByLevel
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinimumOperations(TreeNode root)
    {
        var result = 0;

        var treeNodesQueue = new Queue<TreeNode>();

        if (root.left != null)
        {
            treeNodesQueue.Enqueue(root.left);
        }

        if (root.right != null)
        {
            treeNodesQueue.Enqueue(root.right);
        }

        while (treeNodesQueue.Count > 0)
        {
            var values = DequeueLevel(treeNodesQueue);

            result += GetSwapCount(values);
        }

        return result;
    }

    private static int[] DequeueLevel(Queue<TreeNode> treeNodesQueue)
    {
        var values = new int[treeNodesQueue.Count];

        for (var i = 0; i < values.Length; i++)
        {
            var node = treeNodesQueue.Dequeue();

            values[i] = node.val;

            if (node.left != null)
            {
                treeNodesQueue.Enqueue(node.left);
            }

            if (node.right != null)
            {
                treeNodesQueue.Enqueue(node.right);
            }
        }

        return values;
    }

    private static int GetSwapCount(int[] values)
    {
        var sortedValues = new int[values.Length];
        var originalIndices = new int[values.Length];

        for (var i = 0; i < values.Length; i++)
        {
            sortedValues[i] = values[i];
            originalIndices[i] = i;
        }

        Array.Sort(sortedValues, originalIndices);

        var sortedIndices = new int[values.Length];

        for (var i = 0; i < originalIndices.Length; i++)
        {
            var originalIndex = originalIndices[i];

            sortedIndices[originalIndex] = i;
        }

        var visited = new bool[values.Length];

        var swapCount = 0;

        for (var i = 0; i < values.Length; i++)
        {
            if (visited[i] || sortedIndices[i] == i)
            {
                continue;
            }

            var cycleLength = 0;
            var current = i;

            while (!visited[current])
            {
                visited[current] = true;
                current = sortedIndices[current];
                cycleLength++;
            }

            swapCount += cycleLength - 1;
        }

        return swapCount;
    }
}