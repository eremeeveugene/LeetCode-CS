﻿// --------------------------------------------------------------------------------
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

namespace LeetCode.Algorithms.RangeSumOfBST;

/// <inheritdoc />
public class RangeSumOfBSTDepthFirstSearchRecursive : IRangeSumOfBST
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h), where h is the height of the tree
    /// </summary>
    /// <param name="root"></param>
    /// <param name="low"></param>
    /// <param name="high"></param>
    /// <returns></returns>
    public int RangeSumBST(TreeNode? root, int low, int high)
    {
        if (root == null)
        {
            return 0;
        }

        var result = 0;

        if (root.val >= low && root.val <= high)
        {
            result += root.val;
        }

        if (root.left != null)
        {
            result += RangeSumBST(root.left, low, high);
        }

        if (root.right != null)
        {
            result += RangeSumBST(root.right, low, high);
        }

        return result;
    }
}