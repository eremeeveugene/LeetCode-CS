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

namespace LeetCode.Algorithms.CountValidSubstringsI;

/// <inheritdoc />
public sealed class CountValidSubstringsISlidingWindow : ICountValidSubstringsI
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public long CountValidSubstrings(string s)
    {
        var n = s.Length;

        var windowStartIndex = 0;

        long validSubstringsCount = 0;

        for (var windowEndIndex = 0; windowEndIndex < n; windowEndIndex++)
        {
            var c = s[windowEndIndex];

            if (c == 'c' && windowEndIndex >= 2 && s[windowEndIndex - 1] == 'b' && s[windowEndIndex - 2] == 'a')
            {
                windowStartIndex = windowEndIndex - 1;
            }

            validSubstringsCount += windowEndIndex - windowStartIndex + 1;
        }

        return validSubstringsCount;
    }
}