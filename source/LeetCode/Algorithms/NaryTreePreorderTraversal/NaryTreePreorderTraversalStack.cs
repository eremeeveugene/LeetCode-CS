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

namespace LeetCode.Algorithms.NaryTreePreorderTraversal;

/// <inheritdoc />
public class NaryTreePreorderTraversalStack : INaryTreePreorderTraversal
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<int> Preorder(Node? root)
    {
        if (root == null)
        {
            return new List<int>();
        }

        var result = new List<int>();

        var stack = new Stack<Node>();

        stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();

            result.Add(node.val);

            if (node.children == null)
            {
                continue;
            }

            for (var i = node.children.Count - 1; i >= 0; i--)
            {
                stack.Push(node.children[i]);
            }
        }

        return result;
    }
}