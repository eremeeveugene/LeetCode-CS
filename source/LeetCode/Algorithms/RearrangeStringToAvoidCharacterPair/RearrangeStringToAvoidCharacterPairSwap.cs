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
public sealed class RearrangeStringToAvoidCharacterPairSwap : IRearrangeStringToAvoidCharacterPair
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of s
    ///     Space complexity - O(n), where n is the length of s
    /// </remarks>
    public string RearrangeString(string s, char x, char y)
    {
        var n = s.Length;

        Span<char> characters = stackalloc char[n];

        for (var i = 0; i < n; i++)
        {
            var c = s[i];

            characters[i] = c;
        }

        var index = 0;

        for (var i = 0; i < n; i++)
        {
            var character = characters[i];

            if (character != y)
            {
                continue;
            }

            characters[i] = characters[index];
            characters[index] = y;

            index++;
        }

        return new string(characters);
    }
}