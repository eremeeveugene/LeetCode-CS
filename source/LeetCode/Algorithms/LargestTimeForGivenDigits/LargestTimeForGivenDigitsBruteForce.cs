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

namespace LeetCode.Algorithms.LargestTimeForGivenDigits;

/// <inheritdoc />
public sealed class LargestTimeForGivenDigitsBruteForce : ILargestTimeForGivenDigits
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public string LargestTimeFromDigits(int[] arr)
    {
        var maxMinutes = -1;

        for (var i = 0; i < 4; i++)
        {
            var h1 = arr[i];

            if (h1 > 2)
            {
                continue;
            }

            for (var j = 0; j < 4; j++)
            {
                if (i == j)
                {
                    continue;
                }

                var h2 = arr[j];

                if (h1 == 2 && h2 > 3)
                {
                    continue;
                }

                maxMinutes = Math.Max(maxMinutes, GetMaxTotalMinutes(arr, i, j, (h1 * 10) + h2));
            }
        }

        return maxMinutes < 0 ? string.Empty : BuildTimeString(maxMinutes);
    }

    private static int GetMaxTotalMinutes(int[] arr, int i, int j, int hours)
    {
        var maxTotalMinutes = -1;

        for (var k = 0; k < 4; k++)
        {
            if (i == k || j == k)
            {
                continue;
            }

            var m1 = arr[k];

            if (m1 > 5)
            {
                continue;
            }

            var l = 6 - i - j - k;

            var minutes = (m1 * 10) + arr[l];

            maxTotalMinutes = Math.Max(maxTotalMinutes, (hours * 60) + minutes);
        }

        return maxTotalMinutes;
    }

    private static string BuildTimeString(int totalMinutes)
    {
        var hours = totalMinutes / 60;
        var minutes = totalMinutes % 60;

        var h1 = hours / 10;
        var h2 = hours % 10;
        var m1 = minutes / 10;
        var m2 = minutes % 10;

        return string.Create(
            5,
            (h1, h2, m1, m2),
            static (dest, s) =>
            {
                dest[0] = (char)('0' + s.h1);
                dest[1] = (char)('0' + s.h2);
                dest[2] = ':';
                dest[3] = (char)('0' + s.m1);
                dest[4] = (char)('0' + s.m2);
            });
    }
}