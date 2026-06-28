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

namespace LeetCode.Algorithms.CountTheNumberOfSubstringsWithDominantOnes;

/// <inheritdoc />
public sealed class CountTheNumberOfSubstringsWithDominantOnesCounting : ICountTheNumberOfSubstringsWithDominantOnes
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * sqrt(n))
    ///     Space complexity - O(sqrt(n))
    /// </remarks>
    public int NumberOfSubstrings(string s)
    {
        var n = s.Length;

        var zeroPositions = new List<int>();

        for (var i = 0; i < n; i++)
        {
            if (s[i] == '0')
            {
                zeroPositions.Add(i);
            }
        }

        var totalZeros = zeroPositions.Count;

        var count = 0;

        var zeroIndex = 0;

        for (var left = 0; left < n; left++)
        {
            while (zeroIndex < totalZeros && zeroPositions[zeroIndex] < left)
            {
                zeroIndex++;
            }

            for (var zeros = 0; zeros * zeros <= n; zeros++)
            {
                int rangeStart;
                int rangeEnd;

                if (zeros == 0)
                {
                    rangeStart = left;
                    rangeEnd = zeroIndex < totalZeros ? zeroPositions[zeroIndex] - 1 : n - 1;
                }
                else
                {
                    var lastZeroIndex = zeroIndex + zeros - 1;

                    if (lastZeroIndex >= totalZeros)
                    {
                        break;
                    }

                    rangeStart = zeroPositions[lastZeroIndex];
                    rangeEnd = zeroIndex + zeros < totalZeros ? zeroPositions[zeroIndex + zeros] - 1 : n - 1;
                }

                var minimumRight = left + (zeros * zeros) + zeros - 1;

                var validStart = Math.Max(rangeStart, minimumRight);

                if (validStart <= rangeEnd)
                {
                    count += rangeEnd - validStart + 1;
                }
            }
        }

        return count;
    }
}