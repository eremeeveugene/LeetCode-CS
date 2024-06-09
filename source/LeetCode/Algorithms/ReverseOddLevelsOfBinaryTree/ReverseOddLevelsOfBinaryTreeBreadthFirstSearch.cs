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

namespace LeetCode.Algorithms.ReverseOddLevelsOfBinaryTree;

/// <inheritdoc />
public class ReverseOddLevelsOfBinaryTreeBreadthFirstSearch : IReverseOddLevelsOfBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public TreeNode? ReverseOddLevels(TreeNode? root)
    {
        if (root?.left == null || root.right == null)
        {
            return root;
        }

        var queue = new Queue<(TreeNode left, TreeNode right, int level)>();

        queue.Enqueue((root.left, root.right, 1));

        while (queue.Count > 0)
        {
            var (left, right, level) = queue.Dequeue();

            if (level % 2 == 1)
            {
                (left.val, right.val) = (right.val, left.val);
            }

            if (left.left != null && right.right != null)
            {
                queue.Enqueue((left.left, right.right, level + 1));
            }

            if (left.right != null && right.left != null)
            {
                queue.Enqueue((left.right, right.left, level + 1));
            }
        }

        return root;
    }
}