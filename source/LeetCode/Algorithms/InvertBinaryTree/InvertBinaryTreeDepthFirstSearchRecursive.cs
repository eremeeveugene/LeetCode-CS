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

namespace LeetCode.Algorithms.InvertBinaryTree;

/// <inheritdoc />
public sealed class InvertBinaryTreeDepthFirstSearchRecursive : IInvertBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h), where h is the height of the tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public TreeNode? InvertTree(TreeNode? root)
    {
        if (root == null)
        {
            return null;
        }

        Invert(root);

        return root;
    }

    private void Invert(TreeNode? root)
    {
        if (root == null)
        {
            return;
        }

        (root.left, root.right) = (root.right, root.left);

        InvertTree(root.left);
        InvertTree(root.right);
    }
}