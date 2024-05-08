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

namespace LeetCode.Algorithms.MinimumDepthOfBinaryTree;

/// <inheritdoc />
public class MinimumDepthOfBinaryTreeDepthFirstSearch : IMinimumDepthOfBinaryTree
{
    /// <summary>
    ///     Time complexity - O (n)
    ///     Space complexity - O (n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MinDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var minDepth = int.MaxValue;

        GetMinDepth(root, 1, ref minDepth);

        return minDepth;
    }

    private static void GetMinDepth(TreeNode root, int currentDepth, ref int minDepth)
    {
        if (currentDepth > minDepth)
        {
            return;
        }

        if (root.left == null && root.right == null)
        {
            minDepth = Math.Min(minDepth, currentDepth);

            return;
        }

        currentDepth++;

        if (root.left != null)
        {
            GetMinDepth(root.left, currentDepth, ref minDepth);
        }

        if (root.right != null)
        {
            GetMinDepth(root.right, currentDepth, ref minDepth);
        }
    }
}