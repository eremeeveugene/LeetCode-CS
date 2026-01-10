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

namespace LeetCode.Algorithms.LexicographicallyMinimumStringAfterRemovingStars;

/// <inheritdoc />
public sealed class LexicographicallyMinimumStringAfterRemovingStarsTwoArrays :
    LexicographicallyMinimumStringAfterRemovingStarsBase
{
    private const int Length = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public override string ClearStars(string s)
    {
        var chars = s.ToCharArray();

        var n = chars.Length;

        var latestIndexes = new int[Length];

        for (var i = 0; i < latestIndexes.Length; i++)
        {
            latestIndexes[i] = -1;
        }

        var previousIndexes = new int[n];

        var smallestIndex = Length;

        for (var index = 0; index < n; index++)
        {
            var c = chars[index];

            if (c == '*')
            {
                var latestIndex = latestIndexes[smallestIndex];

                latestIndexes[smallestIndex] = previousIndexes[latestIndex];

                chars[latestIndex] = '*';

                while (smallestIndex < Length && latestIndexes[smallestIndex] == -1)
                {
                    smallestIndex++;
                }
            }
            else
            {
                var letterIndex = c - 'a';

                previousIndexes[index] = latestIndexes[letterIndex];

                latestIndexes[letterIndex] = index;

                smallestIndex = Math.Min(smallestIndex, letterIndex);
            }
        }

        return BuildResult(chars);
    }
}