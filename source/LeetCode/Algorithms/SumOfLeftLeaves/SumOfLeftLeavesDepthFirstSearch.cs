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

namespace LeetCode.Algorithms.SumOfLeftLeaves;

/// <inheritdoc />
public class SumOfLeftLeavesDepthFirstSearch : ISumOfLeftLeaves
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n) for skewed tree, O(log n) for balanced tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int SumOfLeftLeaves(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var sum = 0;

        if (root.left != null)
        {
            if (root.left.left == null && root.left.right == null)
            {
                sum += root.left.val;
            }
            else
            {
                sum += SumOfLeftLeaves(root.left);
            }
        }

        sum += SumOfLeftLeaves(root.right);

        return sum;
    }
}