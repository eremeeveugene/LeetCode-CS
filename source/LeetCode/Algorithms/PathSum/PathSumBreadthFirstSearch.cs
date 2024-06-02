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

namespace LeetCode.Algorithms.PathSum;

/// <inheritdoc />
public class PathSumBreadthFirstSearch : IPathSum
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <param name="targetSum"></param>
    /// <returns></returns>
    public bool HasPathSum(TreeNode? root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }

        var queue = new Queue<(TreeNode node, int sum)>();

        queue.Enqueue((root, root.val));

        while (queue.Count > 0)
        {
            var (currentNode, currentSum) = queue.Dequeue();

            if (currentNode.left == null && currentNode.right == null && currentSum == targetSum)
            {
                return true;
            }

            if (currentNode.left != null)
            {
                queue.Enqueue((currentNode.left, currentSum + currentNode.left.val));
            }

            if (currentNode.right != null)
            {
                queue.Enqueue((currentNode.right, currentSum + currentNode.right.val));
            }
        }

        return false;
    }
}