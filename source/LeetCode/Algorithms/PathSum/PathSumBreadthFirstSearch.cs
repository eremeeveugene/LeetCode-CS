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

        var queue = new Queue<NodeWithSum>();

        queue.Enqueue(new NodeWithSum(root, root.val));

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current.Node.left == null && current.Node.right == null && current.Sum == targetSum)
            {
                return true;
            }

            if (current.Node.left != null)
            {
                queue.Enqueue(new NodeWithSum(current.Node.left, current.Sum + current.Node.left.val));
            }

            if (current.Node.right != null)
            {
                queue.Enqueue(new NodeWithSum(current.Node.right, current.Sum + current.Node.right.val));
            }
        }

        return false;
    }
}