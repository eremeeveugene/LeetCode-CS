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

namespace LeetCode.Algorithms.FindLargestValueInEachTreeRow;

/// <inheritdoc />
public sealed class FindLargestValueInEachTreeRowBreadthFirstSearch : IFindLargestValueInEachTreeRow
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public IList<int> LargestValues(TreeNode? root)
    {
        if (root == null)
        {
            return [];
        }

        var result = new List<int>();

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var maxValue = int.MinValue;
            var levelSize = queue.Count;

            for (var i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();

                maxValue = Math.Max(maxValue, node.val);

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            result.Add(maxValue);
        }

        return result;
    }
}