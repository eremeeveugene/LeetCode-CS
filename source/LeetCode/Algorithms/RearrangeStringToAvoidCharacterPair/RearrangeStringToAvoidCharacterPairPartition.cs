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

namespace LeetCode.Algorithms.RearrangeStringToAvoidCharacterPair;

/// <inheritdoc />
public sealed class RearrangeStringToAvoidCharacterPairPartition : IRearrangeStringToAvoidCharacterPair
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of s
    ///     Space complexity - O(n), where n is the length of s
    /// </remarks>
    public string RearrangeString(string s, char x, char y)
    {
        var n = s.Length;

        Span<char> result = stackalloc char[n];

        var index = 0;

        for (var i = 0; i < n; i++)
        {
            var c = s[i];

            if (c != y)
            {
                continue;
            }

            result[index] = c;

            index++;
        }

        for (var i = 0; i < n; i++)
        {
            var c = s[i];

            if (c == x || c == y)
            {
                continue;
            }

            result[index] = c;

            index++;
        }

        for (var i = 0; i < n; i++)
        {
            var c = s[i];

            if (c != x)
            {
                continue;
            }

            result[index] = c;

            index++;
        }

        return new string(result);
    }
}