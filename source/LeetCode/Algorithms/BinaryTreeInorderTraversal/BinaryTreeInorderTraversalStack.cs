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

namespace LeetCode.Algorithms.BinaryTreeInorderTraversal;

/// <inheritdoc />
public class BinaryTreeInorderTraversalStack : IBinaryTreeInorderTraversal
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="treeNode"></param>
    /// <returns></returns>
    public IList<int> InorderTraversal(TreeNode? treeNode)
    {
        if (treeNode == null)
        {
            return new List<int> { 0 };
        }

        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        var current = treeNode;

        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            result.Add(current.val);

            current = current.right;
        }

        return result;
    }
}