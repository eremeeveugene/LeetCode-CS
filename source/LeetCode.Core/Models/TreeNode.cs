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

// ReSharper disable InconsistentNaming

namespace LeetCode.Core.Models;

/// <summary>
///     Definition for a binary tree node
/// </summary>
public class TreeNode(int? val = null, TreeNode? left = null, TreeNode? right = null)
{
    public TreeNode? left = left;

    public TreeNode? right = right;

    public int val = val ?? 0;

    public TreeNode() : this(0)
    {
    }

    public static TreeNode? BuildTree(IList<int?> values)
    {
        if (!values.Any() || values[0] == null)
        {
            return null;
        }

        var root = new TreeNode(values[0]);

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        var i = 1;

        while (queue.Count > 0 && i < values.Count)
        {
            var current = queue.Dequeue();

            if (i < values.Count && values[i].HasValue)
            {
                current.left = new TreeNode(values[i]);

                queue.Enqueue(current.left);
            }

            i++;

            if (i < values.Count && values[i].HasValue)
            {
                current.right = new TreeNode(values[i]);

                queue.Enqueue(current.right);
            }

            i++;
        }

        return root;
    }
}