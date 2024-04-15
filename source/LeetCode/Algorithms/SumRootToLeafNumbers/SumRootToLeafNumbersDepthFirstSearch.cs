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

namespace LeetCode.Algorithms.SumRootToLeafNumbers;

/// <inheritdoc />
public class SumRootToLeafNumbersDepthFirstSearch : ISumRootToLeafNumbers
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n) for a skewed tree, O(log n) for a balanced tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int SumNumbers(TreeNode? root)
    {
        return root == null ? 0 : GetSum(root, 0);
    }

    private static int GetSum(TreeNode treeNode, int currentSum)
    {
        currentSum = (currentSum * 10) + treeNode.val;

        if (treeNode.left == null && treeNode.right == null)
        {
            return currentSum;
        }

        var sum = 0;

        if (treeNode.left != null)
        {
            sum += GetSum(treeNode.left, currentSum);
        }

        if (treeNode.right != null)
        {
            sum += GetSum(treeNode.right, currentSum);
        }

        return sum;
    }
}