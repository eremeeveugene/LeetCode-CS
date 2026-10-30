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

namespace LeetCode.Algorithms.RegularExpressionMatching;

/// <inheritdoc />
public sealed class RegularExpressionMatchingRecursive : IRegularExpressionMatching
{
    private const char Wildcard = '.';
    private const char Star = '*';
    private const int Unknown = 0;
    private const int NoMatch = 1;
    private const int Match = 2;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public bool IsMatch(string s, string p)
    {
        var m = s.Length;
        var n = p.Length;

        Span<int> memo = stackalloc int[(m + 1) * n];

        return IsMatch(s, p, 0, 0, memo);
    }

    /// <summary>
    ///     Determines whether the suffix of <paramref name="p" /> starting at <paramref name="j" /> matches the entire
    ///     suffix of <paramref name="s" /> starting at <paramref name="i" />.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <param name="p">The pattern.</param>
    /// <param name="i">The start index of the suffix of <paramref name="s" />.</param>
    /// <param name="j">The start index of the suffix of <paramref name="p" />.</param>
    /// <param name="memo">
    ///     The cache of match states, indexed by <c>i * p.Length + j</c>, where each entry is <see cref="Unknown" />,
    ///     <see cref="NoMatch" />, or <see cref="Match" />.
    /// </param>
    /// <returns>
    ///     <see langword="true" /> if the pattern suffix matches the entire string suffix; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    private static bool IsMatch(string s, string p, int i, int j, Span<int> memo)
    {
        var m = s.Length;
        var n = p.Length;

        if (j == n)
        {
            return i == m;
        }

        var memoIndex = (i * n) + j;

        var cachedState = memo[memoIndex];

        if (cachedState != Unknown)
        {
            return cachedState == Match;
        }

        var patternChar = p[j];

        var isFirstMatch = IsFirstMatch(s, i, patternChar);

        var isNextStar = j + 1 < n && p[j + 1] == Star;

        bool isMatch;

        if (isNextStar)
        {
            isMatch = IsMatch(s, p, i, j + 2, memo) || (isFirstMatch && IsMatch(s, p, i + 1, j, memo));
        }
        else
        {
            isMatch = isFirstMatch && IsMatch(s, p, i + 1, j + 1, memo);
        }

        memo[memoIndex] = isMatch ? Match : NoMatch;

        return isMatch;
    }

    /// <summary>
    ///     Determines whether the character of <paramref name="s" /> at <paramref name="index" /> is matched by
    ///     <paramref name="patternChar" />.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <param name="index">The index of the character in <paramref name="s" /> to match.</param>
    /// <param name="patternChar">The pattern character to match against.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="index" /> is within <paramref name="s" /> and the character equals
    ///     <paramref name="patternChar" /> or <paramref name="patternChar" /> is <c>'.'</c>; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsFirstMatch(string s, int index, char patternChar)
    {
        if (index == s.Length)
        {
            return false;
        }

        var stringChar = s[index];

        return patternChar == Wildcard || patternChar == stringChar;
    }
}