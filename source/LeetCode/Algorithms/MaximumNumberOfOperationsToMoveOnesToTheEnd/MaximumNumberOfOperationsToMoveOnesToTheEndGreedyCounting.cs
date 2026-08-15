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

namespace LeetCode.Algorithms.MaximumNumberOfOperationsToMoveOnesToTheEnd;

/// <inheritdoc />
public sealed class MaximumNumberOfOperationsToMoveOnesToTheEndGreedyCounting : IMaximumNumberOfOperationsToMoveOnesToTheEnd
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxOperations(string s)
    {
        var n = s.Length;
        var maxOperations = 0;
        var ones = 0;

        for (var i = 0; i < n; i++)
        {
            if (s[i] == '1')
            {
                ones++;
            }
            else if (i == 0 || s[i - 1] == '1')
            {
                maxOperations += ones;
            }
        }

        return maxOperations;
    }
}