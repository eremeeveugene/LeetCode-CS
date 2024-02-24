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

namespace LeetCode.Algorithms.PathSum;

/// <inheritdoc />
public class PathSumDepthFirstSearch : IPathSum
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity O(log n) for a balanced tree and O(n) for a skewed tree.
    /// </summary>
    /// <param name="root"></param>
    /// <param name="targetSum"></param>
    /// <returns></returns>
    public bool HasPathSum(TreeNode? root, int targetSum)
    {
        return root != null && HasPathSum(root, targetSum, root.val);
    }

    private static bool HasPathSum(TreeNode root, int targetSum, int currentSum)
    {
        if (root.left == null && root.right == null && currentSum == targetSum)
        {
            return true;
        }

        if (root.left != null && HasPathSum(root.left, targetSum, currentSum + root.left.val))
        {
            return true;
        }

        return root.right != null && HasPathSum(root.right, targetSum, currentSum + root.right.val);
    }
}