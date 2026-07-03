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

namespace LeetCode.Algorithms.NumberOfSubstringsContainingAllThreeCharacters;

/// <inheritdoc />
public sealed class NumberOfSubstringsContainingAllThreeCharactersLastPosition : INumberOfSubstringsContainingAllThreeCharacters
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumberOfSubstrings(string s)
    {
        var numberOfSubstrings = 0;

        var lastA = -1;
        var lastB = -1;
        var lastC = -1;

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            switch (c)
            {
                case 'a':
                    lastA = i;
                    break;
                case 'b':
                    lastB = i;
                    break;
                default:
                    lastC = i;
                    break;
            }

            numberOfSubstrings += 1 + Math.Min(lastA, Math.Min(lastB, lastC));
        }

        return numberOfSubstrings;
    }
}