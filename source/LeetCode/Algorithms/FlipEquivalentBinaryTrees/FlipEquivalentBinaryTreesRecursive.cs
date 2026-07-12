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

namespace LeetCode.Algorithms.FlipEquivalentBinaryTrees;

/// <inheritdoc />
public sealed class FlipEquivalentBinaryTreesRecursive : IFlipEquivalentBinaryTrees
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool FlipEquiv(TreeNode? root1, TreeNode? root2)
    {
        if (root1 == null && root2 == null)
        {
            return true;
        }

        if (root1 == null || root2 == null)
        {
            return false;
        }

        if (root1.val != root2.val)
        {
            return false;
        }

        return (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right)) ||
               (FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left));
    }
}