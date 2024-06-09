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
public class ReverseOddLevelsOfBinaryTreeRecursiveDepthFirstSearch : IReverseOddLevelsOfBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h), where h is the height of the tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public TreeNode? ReverseOddLevels(TreeNode? root)
    {
        if (root == null)
        {
            return null;
        }

        Reverse(root.left, root.right, 1);

        return root;
    }

    private static void Reverse(TreeNode? left, TreeNode? right, int level)
    {
        if (left == null || right == null)
        {
            return;
        }

        if (level % 2 == 1)
        {
            (left.val, right.val) = (right.val, left.val);
        }

        level++;

        Reverse(left.left, right.right, level);
        Reverse(left.right, right.left, level);
    }
}