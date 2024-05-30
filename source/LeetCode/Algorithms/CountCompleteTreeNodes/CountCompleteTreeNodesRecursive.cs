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

namespace LeetCode.Algorithms.CountCompleteTreeNodes;

/// <inheritdoc />
public class CountCompleteTreeNodesRecursive : ICountCompleteTreeNodes
{
    /// <summary>
    ///     Time complexity - O(log^2 n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int CountNodes(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var leftHeight = GetLeftHeight(root);
        var rightHeight = GetRightHeight(root);

        if (leftHeight == rightHeight)
        {
            return (1 << leftHeight) - 1;
        }

        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }

    private static int GetLeftHeight(TreeNode? node)
    {
        var height = 0;

        while (node != null)
        {
            height++;

            node = node.left;
        }

        return height;
    }

    private static int GetRightHeight(TreeNode? node)
    {
        var height = 0;

        while (node != null)
        {
            height++;

            node = node.right;
        }

        return height;
    }
}