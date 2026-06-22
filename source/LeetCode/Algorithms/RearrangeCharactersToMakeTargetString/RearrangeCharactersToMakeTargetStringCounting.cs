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

namespace LeetCode.Algorithms.RearrangeCharactersToMakeTargetString;

/// <inheritdoc />
public sealed class RearrangeCharactersToMakeTargetStringCounting : IRearrangeCharactersToMakeTargetString
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int RearrangeCharacters(string s, string target)
    {
        var n = s.Length;
        var m = target.Length;

        Span<int> frequencies = stackalloc int[AlphabetLength];
        Span<int> targetFrequencies = stackalloc int[AlphabetLength];

        for (var i = 0; i < n; i++)
        {
            var c = s[i];

            frequencies[c - 'a']++;
        }

        for (var i = 0; i < m; i++)
        {
            var c = target[i];

            targetFrequencies[c - 'a']++;
        }

        var min = int.MaxValue;

        for (var i = 0; i < targetFrequencies.Length; i++)
        {
            if (targetFrequencies[i] == 0)
            {
                continue;
            }

            min = Math.Min(min, frequencies[i] / targetFrequencies[i]);
        }

        return min;
    }
}