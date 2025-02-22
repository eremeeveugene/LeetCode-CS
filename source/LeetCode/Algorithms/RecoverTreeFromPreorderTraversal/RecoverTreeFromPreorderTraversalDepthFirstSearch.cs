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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.RecoverTreeFromPreorderTraversal;

/// <inheritdoc />
public class RecoverTreeFromPreorderTraversalDepthFirstSearch : IRecoverTreeFromPreorderTraversal
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="traversal"></param>
    /// <returns></returns>
    public TreeNode RecoverFromPreorder(string traversal)
    {
        var depth = 0;

        return Build(traversal, 0, ref depth)!;
    }

    private static TreeNode? Build(string traversal, int currentDepth, ref int i)
    {
        if (i >= traversal.Length)
        {
            return null;
        }

        var depth = GetDepth(traversal, ref i);

        if (depth != currentDepth)
        {
            i -= depth;

            return null;
        }

        var value = GetValue(traversal, ref i);
        var left = Build(traversal, currentDepth + 1, ref i);
        var right = Build(traversal, currentDepth + 1, ref i);

        return new TreeNode(value, left, right);
    }

    private static int GetValue(string traversal, ref int i)
    {
        var value = 0;

        while (i < traversal.Length && char.IsDigit(traversal[i]))
        {
            value *= 10;
            value += traversal[i] - '0';

            i++;
        }

        return value;
    }

    private static int GetDepth(string traversal, ref int i)
    {
        var depth = 0;

        while (i < traversal.Length && traversal[i] == '-')
        {
            depth++;
            i++;
        }

        return depth;
    }
}