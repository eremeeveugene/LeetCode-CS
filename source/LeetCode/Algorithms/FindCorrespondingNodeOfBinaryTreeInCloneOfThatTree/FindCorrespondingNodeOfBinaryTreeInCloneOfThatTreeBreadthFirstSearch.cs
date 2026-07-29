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
public sealed class FindCorrespondingNodeOfBinaryTreeInCloneOfThatTreeBreadthFirstSearch : IFindCorrespondingNodeOfBinaryTreeInCloneOfThatTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
    {
        var originalQueue = new Queue<TreeNode>();
        var clonedQueue = new Queue<TreeNode>();

        originalQueue.Enqueue(original);
        clonedQueue.Enqueue(cloned);

        var originalNode = originalQueue.Dequeue();
        var clonedNode = clonedQueue.Dequeue();

        while (!originalNode.Equals(target))
        {
            if (originalNode.left != null)
            {
                originalQueue.Enqueue(originalNode.left);
            }

            if (originalNode.right != null)
            {
                originalQueue.Enqueue(originalNode.right);
            }

            if (clonedNode.left != null)
            {
                clonedQueue.Enqueue(clonedNode.left);
            }

            if (clonedNode.right != null)
            {
                clonedQueue.Enqueue(clonedNode.right);
            }

            originalNode = originalQueue.Dequeue();
            clonedNode = clonedQueue.Dequeue();
        }

        return clonedNode;
    }
}