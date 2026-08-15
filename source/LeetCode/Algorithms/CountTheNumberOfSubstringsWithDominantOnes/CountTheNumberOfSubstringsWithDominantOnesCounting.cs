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

            count += CountFromLeft(n, zeroPositions, zeroIndex, left);
        }

        return count;
    }

    private static int CountFromLeft(int n, List<int> zeroPositions, int zeroIndex, int left)
    {
        var count = 0;

        for (var zeros = 0; zeros * zeros <= n; zeros++)
        {
            if (!TryGetRange(n, zeroPositions, zeroIndex, left, zeros, out var rangeStart, out var rangeEnd))
            {
                break;
            }

            var minimumRight = left + (zeros * zeros) + zeros - 1;

            var validStart = Math.Max(rangeStart, minimumRight);

            if (validStart <= rangeEnd)
            {
                count += rangeEnd - validStart + 1;
            }
        }

        return count;
    }

    private static bool TryGetRange(int n, List<int> zeroPositions, int zeroIndex, int left, int zeros, out int rangeStart, out int rangeEnd)
    {
        var totalZeros = zeroPositions.Count;

        if (zeros == 0)
        {
            rangeStart = left;
            rangeEnd = zeroIndex < totalZeros ? zeroPositions[zeroIndex] - 1 : n - 1;

            return true;
        }

        var lastZeroIndex = zeroIndex + zeros - 1;

        if (lastZeroIndex >= totalZeros)
        {
            rangeStart = 0;
            rangeEnd = 0;

            return false;
        }

        rangeStart = zeroPositions[lastZeroIndex];
        rangeEnd = zeroIndex + zeros < totalZeros ? zeroPositions[zeroIndex + zeros] - 1 : n - 1;

        return true;
    }
}