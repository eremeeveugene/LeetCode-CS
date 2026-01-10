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
public sealed class MinimumNumberOfOperationsToSortBinaryTreeByLevelBreadthFirstSearch :
    IMinimumNumberOfOperationsToSortBinaryTreeByLevel
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
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

            var indexDictionary = values
                .Select((value, index) => new { Value = value, Index = index })
                .OrderBy(x => x.Value)
                .Select((x, sortedIndex) => new { x.Index, SortedIndex = sortedIndex })
                .ToDictionary(x => x.Index, x => x.SortedIndex);

            var visited = new bool[values.Length];

            for (var i = 0; i < values.Length; i++)
            {
                if (visited[i] || indexDictionary[i] == i)
                {
                    continue;
                }

                var cycleLength = 0;
                var current = i;

                while (!visited[current])
                {
                    visited[current] = true;
                    current = indexDictionary[current];
                    cycleLength++;
                }

                result += cycleLength - 1;
            }
        }

        return result;
    }
}