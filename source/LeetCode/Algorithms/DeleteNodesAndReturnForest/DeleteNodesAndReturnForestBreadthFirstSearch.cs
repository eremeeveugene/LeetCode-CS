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

namespace LeetCode.Algorithms.DeleteNodesAndReturnForest;

/// <inheritdoc />
public sealed class DeleteNodesAndReturnForestBreadthFirstSearch : IDeleteNodesAndReturnForest
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + d)
    ///     Space complexity - O(n + d)
    /// </remarks>
    public IList<TreeNode> DelNodes(TreeNode? root, int[] toDelete)
    {
        if (root == null)
        {
            return new List<TreeNode>();
        }

        var result = new List<TreeNode>();

        var toDeleteHashSet = new HashSet<int>(toDelete);
        var queue = new Queue<TreeNode>();

        var dummyNode = new TreeNode { left = root };

        queue.Enqueue(dummyNode);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            node.left = ProcessChild(node.left, toDeleteHashSet, queue, result);
            node.right = ProcessChild(node.right, toDeleteHashSet, queue, result);
        }

        if (dummyNode.left != null)
        {
            result.Add(dummyNode.left);
        }

        return result;
    }

    private static TreeNode? ProcessChild(TreeNode? child, HashSet<int> toDeleteHashSet, Queue<TreeNode> queue, List<TreeNode> result)
    {
        if (child == null)
        {
            return null;
        }

        queue.Enqueue(child);

        if (!toDeleteHashSet.Contains(child.val))
        {
            return child;
        }

        AddIfKept(child.left, toDeleteHashSet, result);
        AddIfKept(child.right, toDeleteHashSet, result);

        return null;
    }

    private static void AddIfKept(TreeNode? node, HashSet<int> toDeleteHashSet, List<TreeNode> result)
    {
        if (node != null && !toDeleteHashSet.Contains(node.val))
        {
            result.Add(node);
        }
    }
}