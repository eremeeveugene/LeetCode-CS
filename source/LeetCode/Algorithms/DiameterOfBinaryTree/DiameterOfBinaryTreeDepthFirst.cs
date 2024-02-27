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

namespace LeetCode.Algorithms.DiameterOfBinaryTree;

/// <inheritdoc />
public class DiameterOfBinaryTreeDepthFirst : IDiameterOfBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(log n) for a balanced tree, O(n) for a skewed tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int DiameterOfBinaryTree(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var maxDiameter = 0;

        GetMaxDepth(root, ref maxDiameter);

        return maxDiameter;
    }

    private static int GetMaxDepth(TreeNode node, ref int maxDiameter)
    {
        var leftDepth = 0;

        if (node.left != null)
        {
            leftDepth = GetMaxDepth(node.left, ref maxDiameter);
        }

        var rightDepth = 0;

        if (node.right != null)
        {
            rightDepth = GetMaxDepth(node.right, ref maxDiameter);
        }

        maxDiameter = Math.Max(maxDiameter, leftDepth + rightDepth);

        return Math.Max(leftDepth, rightDepth) + 1;
    }
}