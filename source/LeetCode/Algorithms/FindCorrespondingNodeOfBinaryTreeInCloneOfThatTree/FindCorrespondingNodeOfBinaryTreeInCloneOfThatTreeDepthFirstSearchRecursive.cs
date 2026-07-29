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

namespace LeetCode.Algorithms.FindCorrespondingNodeOfBinaryTreeInCloneOfThatTree;

/// <inheritdoc />
public sealed class FindCorrespondingNodeOfBinaryTreeInCloneOfThatTreeDepthFirstSearchRecursive : IFindCorrespondingNodeOfBinaryTreeInCloneOfThatTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n) for a skewed tree, O(log n) for balanced tree
    /// </remarks>
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
    {
        return FindTargetCopy(original, cloned, target)!;
    }

    private static TreeNode? FindTargetCopy(TreeNode? original, TreeNode? cloned, TreeNode target)
    {
        if (original == null)
        {
            return null;
        }

        if (original.Equals(target))
        {
            return cloned;
        }

        return FindTargetCopy(original.left, cloned!.left, target) ?? FindTargetCopy(original.right, cloned!.right, target);
    }
}