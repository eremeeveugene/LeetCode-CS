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

namespace LeetCode.Algorithms.SymmetricTree;

/// <inheritdoc />
public class SymmetricTreeIterative : ISymmetricTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(log n) for a balanced tree, O(n) for an unbalanced tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsSymmetric(TreeNode? root)
    {
        if (root == null)
        {
            return true;
        }

        var queue = new Queue<TreeNode?>();

        queue.Enqueue(root.left);
        queue.Enqueue(root.right);

        while (queue.Count > 0)
        {
            var left = queue.Dequeue();
            var right = queue.Dequeue();

            if (left == null && right == null)
            {
                continue;
            }

            if (left == null || right == null)
            {
                return false;
            }

            if (left.val != right.val)
            {
                return false;
            }

            queue.Enqueue(left.left);
            queue.Enqueue(right.right);
            queue.Enqueue(left.right);
            queue.Enqueue(right.left);
        }

        return true;
    }
}