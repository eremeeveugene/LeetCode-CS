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

namespace LeetCode.Algorithms.SumOfRootToLeafBinaryNumbers;

/// <inheritdoc />
public sealed class SumOfRootToLeafBinaryNumbersDepthFirstSearch : ISumOfRootToLeafBinaryNumbers
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h), where h is the height of the tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int SumRootToLeaf(TreeNode root)
    {
        return SumRootToLeaf(root, 0);
    }

    private static int SumRootToLeaf(TreeNode treeNode, int value)
    {
        value = (value << 1) + treeNode.val;

        if (treeNode.left == null && treeNode.right == null)
        {
            return value;
        }

        var sum = 0;

        if (treeNode.left != null)
        {
            sum += SumRootToLeaf(treeNode.left, value);
        }

        if (treeNode.right != null)
        {
            sum += SumRootToLeaf(treeNode.right, value);
        }

        return sum;
    }
}