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

namespace LeetCode.Algorithms.LargestSubstringBetweenTwoEqualCharacters;

/// <inheritdoc />
public sealed class LargestSubstringBetweenTwoEqualCharactersLookup : ILargestSubstringBetweenTwoEqualCharacters
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        Span<int> positions = stackalloc int[AlphabetLength];

        var maxLength = -1;

        for (var i = 0; i < s.Length; i++)
        {
            var index = s[i] - 'a';

            var position = positions[index];

            if (position == 0)
            {
                positions[index] = i + 1;
            }
            else
            {
                var length = i - position;

                maxLength = Math.Max(maxLength, length);
            }
        }

        return maxLength;
    }
}