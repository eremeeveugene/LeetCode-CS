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

namespace LeetCode.Algorithms.DistributeCoinsInBinaryTree;

/// <inheritdoc />
public class DistributeCoinsInBinaryTreeDepthFirstSearch : IDistributeCoinsInBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n) for a skewed tree, O(log n) for a balanced tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int DistributeCoins(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var moves = 0;

        DistributeCoins(root, ref moves);

        return moves;
    }

    private static int DistributeCoins(TreeNode? node, ref int moves)
    {
        if (node == null)
        {
            return 0;
        }

        var left = DistributeCoins(node.left, ref moves);
        var right = DistributeCoins(node.right, ref moves);

        moves += Math.Abs(left) + Math.Abs(right);

        return node.val + left + right - 1;
    }
}