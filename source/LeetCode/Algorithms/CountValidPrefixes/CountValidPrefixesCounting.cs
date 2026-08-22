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

namespace LeetCode.Algorithms.CountValidPrefixes;

/// <inheritdoc />
public sealed class CountValidPrefixesCounting : ICountValidPrefixes
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountValidPrefixes(string s)
    {
        var n = s.Length;

        var result = 0;

        var balance = 0;

        for (var i = 0; i < n; i++)
        {
            var c = s[i];

            if (c == '0')
            {
                balance++;
            }
            else
            {
                balance--;
            }

            if (balance is < -1 or > 1)
            {
                continue;
            }

            result++;
        }

        return result;
    }
}