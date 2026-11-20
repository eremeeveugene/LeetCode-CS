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

namespace LeetCode.Algorithms.AverageOfLevelsInBinaryTree;

/// <inheritdoc />
public sealed class AverageOfLevelsInBinaryTreeBreadthFirstSearch : IAverageOfLevelsInBinaryTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(w)
    /// </remarks>
    public IList<double> AverageOfLevels(TreeNode root)
    {
        var result = new List<double>();

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var levelCount = queue.Count;

            var levelSum = 0L;

            for (var i = 0; i < levelCount; i++)
            {
                var node = queue.Dequeue();

                levelSum += node.val;

                if (node.left is not null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right is not null)
                {
                    queue.Enqueue(node.right);
                }
            }

            var average = (double)levelSum / levelCount;

            result.Add(average);
        }

        return result;
    }
}