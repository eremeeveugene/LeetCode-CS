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

namespace LeetCode.Algorithms.CheckAdjacentDigitDifferences;

/// <inheritdoc />
public sealed class CheckAdjacentDigitDifferencesIterative : ICheckAdjacentDigitDifferences
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool IsAdjacentDiffAtMostTwo(string s)
    {
        for (var i = 0; i < s.Length - 1; i++)
        {
            var difference = s[i] - s[i + 1];

            if (difference is < -2 or > 2)
            {
                return false;
            }
        }

        return true;
    }
}