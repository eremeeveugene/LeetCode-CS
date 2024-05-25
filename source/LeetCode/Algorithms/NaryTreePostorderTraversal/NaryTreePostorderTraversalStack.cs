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

namespace LeetCode.Algorithms.NaryTreePostorderTraversal;

/// <inheritdoc />
public class NaryTreePostorderTraversalStack : INaryTreePostorderTraversal
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<int> Postorder(Node? root)
    {
        if (root == null)
        {
            return new List<int>();
        }

        var result = new List<int>();

        var traverseStack = new Stack<Node>();

        traverseStack.Push(root);

        while (traverseStack.Count > 0)
        {
            var node = traverseStack.Pop();

            result.Insert(0, node.val);

            if (node.children == null)
            {
                continue;
            }

            foreach (var child in node.children)
            {
                traverseStack.Push(child);
            }
        }

        return result;
    }
}