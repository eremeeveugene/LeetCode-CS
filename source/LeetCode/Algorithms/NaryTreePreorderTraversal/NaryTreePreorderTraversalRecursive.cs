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
public class NaryTreePreorderTraversalRecursive : INaryTreePreorderTraversal
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

        Preorder(root, result);

        return result;
    }

    private static void Preorder(Node root, ICollection<int> result)
    {
        result.Add(root.val);

        if (root.children == null)
        {
            return;
        }

        foreach (var child in root.children)
        {
            Preorder(child, result);
        }
    }
}