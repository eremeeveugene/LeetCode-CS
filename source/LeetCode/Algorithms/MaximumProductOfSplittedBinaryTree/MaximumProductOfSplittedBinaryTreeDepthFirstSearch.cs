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

namespace LeetCode.Algorithms.MaximumProductOfSplittedBinaryTree;

/// <inheritdoc />
public sealed class MaximumProductOfSplittedBinaryTreeDepthFirstSearch : IMaximumProductOfSplittedBinaryTree
{
    private const int Modulo = 1_000_000_007;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the number of nodes in the binary tree
    ///     Space complexity - O(h), where h is the height of the tree
    /// </remarks>
    public int MaxProduct(TreeNode root)
    {
        long maximumProduct = 0;

        var totalSum = GetTotalSum(root);

        FindMaximumProduct(root);

        return (int)(maximumProduct % Modulo);

        long GetTotalSum(TreeNode treeNode)
        {
            long sum = treeNode.val;

            if (treeNode.left != null)
            {
                sum += GetTotalSum(treeNode.left);
            }

            if (treeNode.right != null)
            {
                sum += GetTotalSum(treeNode.right);
            }

            return sum;
        }

        long FindMaximumProduct(TreeNode treeNode)
        {
            long sum = treeNode.val;

            if (treeNode.left != null)
            {
                sum += FindMaximumProduct(treeNode.left);
            }

            if (treeNode.right != null)
            {
                sum += FindMaximumProduct(treeNode.right);
            }

            var product = sum * (totalSum - sum);

            maximumProduct = Math.Max(maximumProduct, product);

            return sum;
        }
    }
}