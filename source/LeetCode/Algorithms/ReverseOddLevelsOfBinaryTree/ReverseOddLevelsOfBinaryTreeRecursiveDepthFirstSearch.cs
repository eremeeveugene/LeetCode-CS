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

namespace LeetCode.Algorithms.ReverseOddLevelsOfBinaryTree;

/// <inheritdoc />
public sealed class ReverseOddLevelsOfBinaryTreeRecursiveDepthFirstSearch : IReverseOddLevelsOfBinaryTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h), where h is the height of the tree
    /// </remarks>
    public TreeNode? ReverseOddLevels(TreeNode? root)
    {
        if (root == null)
        {
            return null;
        }

        Reverse(root.left, root.right, 1);

        return root;
    }

    private static void Reverse(TreeNode? leftNode, TreeNode? rightNode, int level)
    {
        if (leftNode == null || rightNode == null)
        {
            return;
        }

        if (level % 2 == 1)
        {
            (leftNode.val, rightNode.val) = (rightNode.val, leftNode.val);
        }

        level++;

        Reverse(leftNode.left, rightNode.right, level);
        Reverse(leftNode.right, rightNode.left, level);
    }
}