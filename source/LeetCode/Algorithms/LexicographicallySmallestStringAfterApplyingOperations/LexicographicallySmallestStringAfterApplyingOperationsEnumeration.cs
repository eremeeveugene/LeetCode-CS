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

namespace LeetCode.Algorithms.LexicographicallySmallestStringAfterApplyingOperations;

/// <inheritdoc />
public sealed class LexicographicallySmallestStringAfterApplyingOperationsEnumeration : ILexicographicallySmallestStringAfterApplyingOperations
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </remarks>
    public string FindLexSmallestString(string s, int a, int b)
    {
        var n = s.Length;

        Span<char> candidate = stackalloc char[n];
        Span<char> best = stackalloc char[n];

        s.CopyTo(best);

        for (var rotation = 0; rotation < n; rotation++)
        {
            var shift = rotation * b % n;

            for (var i = 0; i < n; i++)
            {
                candidate[(i + shift) % n] = s[i];
            }

            if (b % 2 == 1)
            {
                var evenAdds = GetMinimizingAdds(candidate[0], a);

                for (var i = 0; i < n; i += 2)
                {
                    candidate[i] = GetIncrementedChar(candidate[i], evenAdds * a);
                }
            }

            var oddAdds = GetMinimizingAdds(candidate[1], a);

            for (var i = 1; i < n; i += 2)
            {
                candidate[i] = GetIncrementedChar(candidate[i], oddAdds * a);
            }

            if (candidate.SequenceCompareTo(best) < 0)
            {
                candidate.CopyTo(best);
            }
        }

        return new string(best);
    }

    /// <summary>
    ///     Adds a value to a digit character, modulo 10.
    /// </summary>
    /// <param name="c">The digit character.</param>
    /// <param name="value">The value to add.</param>
    /// <returns>The resulting digit character.</returns>
    private static char GetIncrementedChar(char c, int value)
    {
        var digit = c - '0';

        var incrementedDigit = (digit + value) % 10;

        return (char)('0' + incrementedDigit);
    }

    /// <summary>
    ///     Finds the number of additions of <paramref name="a" /> that gives the smallest digit, modulo 10.
    /// </summary>
    /// <param name="c">The starting digit character.</param>
    /// <param name="a">The value added to the digit on each addition.</param>
    /// <returns>The smallest number of additions that minimizes the digit.</returns>
    private static int GetMinimizingAdds(char c, int a)
    {
        var minChar = c;
        var minAdds = 0;

        for (var adds = 1; adds < 10; adds++)
        {
            var newChar = GetIncrementedChar(c, adds * a);

            if (newChar >= minChar)
            {
                continue;
            }

            minChar = newChar;
            minAdds = adds;
        }

        return minAdds;
    }
}