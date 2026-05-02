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

namespace LeetCode.Algorithms.RotatedDigits;

/// <inheritdoc />
public sealed class RotatedDigitsDynamicProgramming : IRotatedDigits
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int RotatedDigits(int n)
    {
        Span<int> states = stackalloc int[n + 1];

        var result = 0;

        for (var i = 1; i <= n; i++)
        {
            var digit = i % 10;

            var prefix = states[i / 10];

            if (prefix == -1 || digit is 3 or 4 or 7)
            {
                states[i] = -1;
            }
            else if (prefix == 1 || digit is 2 or 5 or 6 or 9)
            {
                states[i] = 1;

                result++;
            }
        }

        return result;
    }
}