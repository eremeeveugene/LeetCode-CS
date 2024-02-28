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

namespace LeetCode.Algorithms.FindBottomLeftTreeValue;

/// <inheritdoc />
public class FindBottomLeftTreeValueDepthFirst : IFindBottomLeftTreeValue
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(log n) for a balanced tree, O(n) for a skewed tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int FindBottomLeftValue(TreeNode? root)
    {
        return root == null ? 0 : FindBottomLeftValue(root, 0).Item1;
    }

    private static (int, int) FindBottomLeftValue(TreeNode root, int lastRow)
    {
        if (root.left == null && root.right == null)
        {
            return (root.val, lastRow);
        }

        var leftValue = (0, 0);

        if (root.left != null)
        {
            leftValue = FindBottomLeftValue(root.left, lastRow + 1);
        }

        var rightValue = (0, 0);

        if (root.right != null)
        {
            rightValue = FindBottomLeftValue(root.right, lastRow + 1);
        }

        return leftValue.Item2 >= rightValue.Item2 ? leftValue : rightValue;
    }
}