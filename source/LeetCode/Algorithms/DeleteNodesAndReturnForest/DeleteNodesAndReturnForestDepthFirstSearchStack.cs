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
public sealed class DeleteNodesAndReturnForestDepthFirstSearchStack : IDeleteNodesAndReturnForest
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
        var stack = new Stack<TreeNode>();

        var dummyNode = new TreeNode { left = root };

        stack.Push(dummyNode);

        while (stack.Count > 0)
        {
            var node = stack.Pop();

            node.left = ProcessChild(node.left, toDeleteHashSet, stack, result);
            node.right = ProcessChild(node.right, toDeleteHashSet, stack, result);
        }

        if (dummyNode.left != null)
        {
            result.Add(dummyNode.left);
        }

        return result;
    }

    private static TreeNode? ProcessChild(TreeNode? child, HashSet<int> toDeleteHashSet, Stack<TreeNode> stack, List<TreeNode> result)
    {
        if (child == null)
        {
            return null;
        }

        stack.Push(child);

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