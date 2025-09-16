// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

// ReSharper disable InconsistentNaming

using LeetCode.Core.Exceptions;

namespace LeetCode.Core.Models;

/// <summary>
///     Definition for a binary tree node
/// </summary>
public class TreeNode
{
    public TreeNode? left;

    public TreeNode? right;

    public int val;

    public TreeNode(int? val = null, TreeNode? left = null, TreeNode? right = null)
    {
        this.left = left;
        this.right = right;
        this.val = val ?? 0;
    }

    public static TreeNode ToTreeNodeOrThrow(IEnumerable<int?> values)
    {
        return ToTreeNode(values) ?? throw new TreeNodeBuildException();
    }

    public static TreeNode? ToTreeNode(IEnumerable<int?> values)
    {
        using var enumerator = values.GetEnumerator();

        if (!enumerator.MoveNext() || enumerator.Current == null)
        {
            return null;
        }

        var root = new TreeNode(enumerator.Current.Value);
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (enumerator.MoveNext())
            {
                if (enumerator.Current.HasValue)
                {
                    current.left = new TreeNode(enumerator.Current.Value);

                    queue.Enqueue(current.left);
                }
            }
            else
            {
                break;
            }

            if (enumerator.MoveNext())
            {
                if (!enumerator.Current.HasValue)
                {
                    continue;
                }

                current.right = new TreeNode(enumerator.Current.Value);

                queue.Enqueue(current.right);
            }
            else
            {
                break;
            }
        }

        return root;
    }
}