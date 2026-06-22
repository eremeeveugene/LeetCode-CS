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

namespace LeetCode.Algorithms.MaximumNumberOfBalloons;

/// <inheritdoc />
public sealed class MaximumNumberOfBalloonsCounting : IMaximumNumberOfBalloons
{
    private const byte AlphabetLength = 'z' - 'a' + 1;
    private const string Balloon = "balloon";

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public int MaxNumberOfBalloons(string text)
    {
        var n = text.Length;
        var m = Balloon.Length;

        Span<int> frequencies = stackalloc int[AlphabetLength];
        Span<int> targetFrequencies = stackalloc int[AlphabetLength];

        for (var i = 0; i < n; i++)
        {
            var c = text[i];

            frequencies[c - 'a']++;
        }

        for (var i = 0; i < m; i++)
        {
            var c = Balloon[i];

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