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

namespace LeetCode.Algorithms.RotateString;

/// <inheritdoc />
public sealed class RotateStringHashing : IRotateString
{
    private const ulong Base = 131;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool RotateString(string s, string goal)
    {
        var n = s.Length;

        if (n != goal.Length)
        {
            return false;
        }

        var goalHash = 0UL;
        var windowHash = 0UL;
        var power = 1UL;

        for (var i = 0; i < n; i++)
        {
            goalHash = (goalHash * Base) + goal[i];
            windowHash = (windowHash * Base) + s[i];

            if (i > 0)
            {
                power *= Base;
            }
        }

        for (var start = 0; start < n; start++)
        {
            if (windowHash == goalHash)
            {
                return true;
            }

            if (start == n - 1)
            {
                break;
            }

            var left = s[start];
            var right = s[start];

            windowHash -= left * power;
            windowHash = (windowHash * Base) + right;
        }

        return false;
    }
}