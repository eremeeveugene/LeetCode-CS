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
public sealed class FindCorrespondingNodeOfBinaryTreeInCloneOfThatTreeDepthFirstSearchStack : IFindCorrespondingNodeOfBinaryTreeInCloneOfThatTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n) for a skewed tree, O(log n) for balanced tree
    /// </remarks>
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
    {
        var originalStack = new Stack<TreeNode>();
        var clonedStack = new Stack<TreeNode>();

        originalStack.Push(original);
        clonedStack.Push(cloned);

        var originalNode = originalStack.Pop();
        var clonedNode = clonedStack.Pop();

        while (!originalNode.Equals(target))
        {
            if (originalNode.left != null)
            {
                originalStack.Push(originalNode.left);
            }

            if (originalNode.right != null)
            {
                originalStack.Push(originalNode.right);
            }

            if (clonedNode.left != null)
            {
                clonedStack.Push(clonedNode.left);
            }

            if (clonedNode.right != null)
            {
                clonedStack.Push(clonedNode.right);
            }

            originalNode = originalStack.Pop();
            clonedNode = clonedStack.Pop();
        }

        return clonedNode;
    }
}