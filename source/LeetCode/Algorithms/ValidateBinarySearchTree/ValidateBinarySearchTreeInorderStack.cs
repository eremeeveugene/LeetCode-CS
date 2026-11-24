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

namespace LeetCode.Algorithms.ValidateBinarySearchTree;

/// <inheritdoc />
public sealed class ValidateBinarySearchTreeInorderStack : IValidateBinarySearchTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h)
    /// </remarks>
    public bool IsValidBST(TreeNode root)
    {
        var stack = new Stack<TreeNode>();

        var currentNode = root;

        var previousValue = long.MinValue;

        while (currentNode is not null || stack.Count > 0)
        {
            while (currentNode is not null)
            {
                stack.Push(currentNode);

                currentNode = currentNode.left;
            }

            var node = stack.Pop();

            if (node.val <= previousValue)
            {
                return false;
            }

            previousValue = node.val;

            currentNode = node.right;
        }

        return true;
    }
}