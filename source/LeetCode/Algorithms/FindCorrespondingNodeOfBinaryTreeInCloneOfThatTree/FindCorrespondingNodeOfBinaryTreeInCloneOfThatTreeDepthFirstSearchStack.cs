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

namespace LeetCode.Algorithms.FindCorrespondingNodeOfBinaryTreeInCloneOfThatTree;

/// <inheritdoc />
public class FindCorrespondingNodeOfBinaryTreeInCloneOfThatTreeDepthFirstSearchStack :
    IFindCorrespondingNodeOfBinaryTreeInCloneOfThatTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n) for a skewed tree, O(log n) for balanced tree
    /// </summary>
    /// <param name="original"></param>
    /// <param name="cloned"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public TreeNode? GetTargetCopy(TreeNode? original, TreeNode? cloned, TreeNode? target)
    {
        if (original == null || cloned == null || target == null)
        {
            return null;
        }

        var originalStack = new Stack<TreeNode>();
        var clonedStack = new Stack<TreeNode>();

        originalStack.Push(original);
        clonedStack.Push(cloned);

        while (originalStack.Count > 0)
        {
            var originalNode = originalStack.Pop();
            var clonedNode = clonedStack.Pop();

            if (originalNode.Equals(target))
            {
                return clonedNode;
            }

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
        }

        return null;
    }
}