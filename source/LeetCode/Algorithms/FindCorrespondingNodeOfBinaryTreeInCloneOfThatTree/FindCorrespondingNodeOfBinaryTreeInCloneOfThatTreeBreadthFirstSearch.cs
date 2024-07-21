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
public class FindCorrespondingNodeOfBinaryTreeInCloneOfThatTreeBreadthFirstSearch :
    IFindCorrespondingNodeOfBinaryTreeInCloneOfThatTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
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

        var originalQueue = new Queue<TreeNode>();
        var clonedQueue = new Queue<TreeNode>();

        originalQueue.Enqueue(original);
        clonedQueue.Enqueue(cloned);

        while (originalQueue.Count > 0)
        {
            var originalNode = originalQueue.Dequeue();
            var clonedNode = clonedQueue.Dequeue();

            if (originalNode.Equals(target))
            {
                return clonedNode;
            }

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
        }

        return null;
    }
}