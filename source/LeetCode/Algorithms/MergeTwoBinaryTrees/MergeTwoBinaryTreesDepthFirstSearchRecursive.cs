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

namespace LeetCode.Algorithms.MergeTwoBinaryTrees;

/// <inheritdoc />
public class MergeTwoBinaryTreesDepthFirstSearchRecursive : IMergeTwoBinaryTrees
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m) for a skewed trees, O(log n + log m) for a balanced trees
    /// </summary>
    /// <param name="root1"></param>
    /// <param name="root2"></param>
    /// <returns></returns>
    public TreeNode? MergeTrees(TreeNode? root1, TreeNode? root2)
    {
        if (root1 == null && root2 == null)
        {
            return null;
        }

        if (root1 == null)
        {
            return root2;
        }

        if (root2 == null)
        {
            return root1;
        }

        root1.val += root2.val;
        root1.left = MergeTrees(root1.left, root2.left);
        root1.right = MergeTrees(root1.right, root2.right);

        return root1;
    }
}