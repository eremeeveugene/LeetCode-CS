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
public class ReverseOddLevelsOfBinaryTreeStackDepthFirstSearch : IReverseOddLevelsOfBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h), where h is the height of the tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public TreeNode? ReverseOddLevels(TreeNode? root)
    {
        if (root?.left == null || root.right == null)
        {
            return root;
        }

        var stack = new Stack<(TreeNode left, TreeNode right, int level)>();

        stack.Push((root.left, root.right, 1));

        while (stack.Count > 0)
        {
            var (left, right, level) = stack.Pop();

            if (level % 2 == 1)
            {
                (left.val, right.val) = (right.val, left.val);
            }

            if (left.left != null && right.right != null)
            {
                stack.Push((left.left, right.right, level + 1));
            }

            if (left.right != null && right.left != null)
            {
                stack.Push((left.right, right.left, level + 1));
            }
        }

        return root;
    }
}