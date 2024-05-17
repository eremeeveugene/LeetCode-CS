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

namespace LeetCode.Algorithms.DeleteLeavesWithGivenValue;

/// <inheritdoc />
public class DeleteLeavesWithGivenValueDepthFirstSearch : IDeleteLeavesWithGivenValue
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n) for the skewed tree, O(log n) for a balanced tree
    /// </summary>
    /// <param name="root"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public TreeNode? RemoveLeafNodes(TreeNode? root, int target)
    {
        if (root == null)
        {
            return null;
        }

        root.left = RemoveLeafNodes(root.left, target);
        root.right = RemoveLeafNodes(root.right, target);

        if (root.left == null && root.right == null)
        {
            return root.val == target ? null : root;
        }

        return root;
    }
}