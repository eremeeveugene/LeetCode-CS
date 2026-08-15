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

namespace LeetCode.Algorithms.DeleteColumnsToMakeSorted2;

/// <inheritdoc />
public sealed class DeleteColumnsToMakeSorted2Greedy : IDeleteColumnsToMakeSorted2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinDeletionSize(string[] strs)
    {
        var result = 0;

        var n = strs.Length;
        var m = strs[0].Length;

        Span<bool> skipped = stackalloc bool[n - 1];

        for (var i = 0; i < m; i++)
        {
            if (NeedsDeletion(strs, skipped, i))
            {
                result++;

                continue;
            }

            MarkStrictlyIncreasing(strs, skipped, i);
        }

        return result;
    }

    private static bool NeedsDeletion(string[] strs, ReadOnlySpan<bool> skipped, int column)
    {
        for (var j = 0; j < skipped.Length; j++)
        {
            if (skipped[j] || strs[j][column] <= strs[j + 1][column])
            {
                continue;
            }

            return true;
        }

        return false;
    }

    private static void MarkStrictlyIncreasing(string[] strs, Span<bool> skipped, int column)
    {
        for (var j = 0; j < skipped.Length; j++)
        {
            if (skipped[j])
            {
                continue;
            }

            if (strs[j][column] < strs[j + 1][column])
            {
                skipped[j] = true;
            }
        }
    }
}