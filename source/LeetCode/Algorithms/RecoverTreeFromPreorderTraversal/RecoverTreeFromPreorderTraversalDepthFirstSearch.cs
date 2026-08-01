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

namespace LeetCode.Algorithms.RecoverTreeFromPreorderTraversal;

/// <inheritdoc />
public sealed class RecoverTreeFromPreorderTraversalDepthFirstSearch : IRecoverTreeFromPreorderTraversal
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public TreeNode RecoverFromPreorder(string traversal)
    {
        var index = 0;

        return Build(traversal, 0, ref index)!;
    }

    private static TreeNode? Build(string traversal, int currentDepth, ref int index)
    {
        if (index >= traversal.Length)
        {
            return null;
        }

        var depth = GetDepth(traversal, ref index);

        if (depth != currentDepth)
        {
            index -= depth;

            return null;
        }

        var value = GetValue(traversal, ref index);
        var left = Build(traversal, currentDepth + 1, ref index);
        var right = Build(traversal, currentDepth + 1, ref index);

        return new TreeNode(value, left, right);
    }

    private static int GetValue(string traversal, ref int index)
    {
        var value = 0;

        while (index < traversal.Length && char.IsDigit(traversal[index]))
        {
            value *= 10;
            value += traversal[index] - '0';

            index++;
        }

        return value;
    }

    private static int GetDepth(string traversal, ref int index)
    {
        var depth = 0;

        while (traversal[index] == '-')
        {
            depth++;
            index++;
        }

        return depth;
    }
}