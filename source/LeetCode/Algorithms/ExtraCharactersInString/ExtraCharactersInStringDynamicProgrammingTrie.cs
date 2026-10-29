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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.ExtraCharactersInString;

/// <inheritdoc />
public sealed class ExtraCharactersInStringDynamicProgrammingTrie : IExtraCharactersInString
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(L^2 × n), where L is the length of s and n is the length of the longest word in the dictionary
    ///     Space complexity - O(m * n + L), where L is the length of s, m is the number of words in the dictionary and n is
    ///     the length of the longest word in the dictionary
    /// </remarks>
    public int MinExtraChar(string s, string[] dictionary)
    {
        var trie = new Trie(dictionary);

        var n = s.Length;

        var dp = new int[n + 1];

        for (var start = n - 1; start >= 0; start--)
        {
            dp[start] = dp[start + 1] + 1;

            var prefixLengths = trie.FindPrefixLengths(s.AsSpan(start));

            var prefixLengthsCount = prefixLengths.Count;

            for (var i = 0; i < prefixLengthsCount; i++)
            {
                var prefixLength = prefixLengths[i];

                dp[start] = Math.Min(dp[start], dp[start + prefixLength]);
            }
        }

        return dp[0];
    }
}