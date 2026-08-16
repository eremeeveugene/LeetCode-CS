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

// ReSharper disable InconsistentNaming
#pragma warning disable S101

namespace LeetCode.Core.Models;

/// <summary>
///     Definition for an n-ary tree node
/// </summary>
public sealed class Node
{
    public IList<Node>? children;

    public int val;

    public Node(int? val = null, IList<Node>? children = null)
    {
        this.children = children;
        this.val = val ?? 0;
    }

    public static Node? ToNode(int?[] values)
    {
        if (values.Length == 0 || values[0] == null)
        {
            return null;
        }

        var root = new Node(values[0]);

        var queue = new Queue<Node>();

        queue.Enqueue(root);

        var i = 2;

        while (queue.Count > 0 && i < values.Length)
        {
            var current = queue.Dequeue();

            current.children = [];

            while (i < values.Length && values[i] != null)
            {
                var child = new Node(values[i]);

                current.children.Add(child);

                queue.Enqueue(child);

                i++;
            }

            i++;
        }

        return root;
    }
}