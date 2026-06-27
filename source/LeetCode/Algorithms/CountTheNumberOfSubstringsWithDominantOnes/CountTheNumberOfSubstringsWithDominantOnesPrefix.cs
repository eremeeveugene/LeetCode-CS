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
public sealed class CountTheNumberOfSubstringsWithDominantOnesPrefix : ICountTheNumberOfSubstringsWithDominantOnes
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * sqrt(n))
    ///     Space complexity - O(n)
    /// </remarks>
    public int NumberOfSubstrings(string s)
    {
        var n = s.Length;

        Span<int> previousZeroBoundary = stackalloc int[n + 1];

        previousZeroBoundary[0] = -1;

        for (var i = 0; i < n; i++)
        {
            if (i == 0 || s[i - 1] == '0')
            {
                previousZeroBoundary[i + 1] = i;
            }
            else
            {
                previousZeroBoundary[i + 1] = previousZeroBoundary[i];
            }
        }

        var count = 0;

        for (var right = 1; right <= n; right++)
        {
            var zeros = s[right - 1] == '0' ? 1 : 0;

            var boundary = right;

            while (boundary > 0 && zeros * zeros <= n)
            {
                var ones = right - previousZeroBoundary[boundary] - zeros;

                if (zeros * zeros <= ones)
                {
                    count += Math.Min(boundary - previousZeroBoundary[boundary], ones - (zeros * zeros) + 1);
                }

                boundary = previousZeroBoundary[boundary];

                zeros++;
            }
        }

        return count;
    }
}