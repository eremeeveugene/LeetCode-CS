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

namespace LeetCode.Algorithms.BalanceABinarySearchTree;

/// <inheritdoc />
public sealed class BalanceABinarySearchTreeInorderTraversal : IBalanceABinarySearchTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public TreeNode BalanceBST(TreeNode root)
    {
        var sortedNodes = GetSortedNodes(root);

        return BuildBalancedTree(sortedNodes, 0, sortedNodes.Count - 1);
    }

    /// <summary>
    ///     Collects the existing nodes in ascending order using an iterative inorder traversal.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    private static List<TreeNode> GetSortedNodes(TreeNode root)
    {
        var sortedNodes = new List<TreeNode>();
        var nodeStack = new Stack<TreeNode>();

        var current = root;

        while (current is not null || nodeStack.Count > 0)
        {
            if (current is not null)
            {
                nodeStack.Push(current);

                current = current.left;
            }
            else
            {
                current = nodeStack.Pop();

                sortedNodes.Add(current);

                current = current.right;
            }
        }

        return sortedNodes;
    }

    /// <summary>
    ///     Reuses the middle node of each sorted range as its root and rebuilds its child links.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(log n)
    /// </remarks>
    private static TreeNode BuildBalancedTree(List<TreeNode> sortedNodes, int left, int right)
    {
        var middle = left + ((right - left) / 2);

        var root = sortedNodes[middle];

        root.left = left < middle ? BuildBalancedTree(sortedNodes, left, middle - 1) : null;
        root.right = middle < right ? BuildBalancedTree(sortedNodes, middle + 1, right) : null;

        return root;
    }
}