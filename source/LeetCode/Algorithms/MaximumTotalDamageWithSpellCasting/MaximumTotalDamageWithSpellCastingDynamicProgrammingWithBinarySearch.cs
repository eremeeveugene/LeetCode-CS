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

namespace LeetCode.Algorithms.MaximumTotalDamageWithSpellCasting;

/// <inheritdoc />
public class MaximumTotalDamageWithSpellCastingDynamicProgrammingWithBinarySearch : IMaximumTotalDamageWithSpellCasting
{
    /// <summary>
    ///     Time complexity - O(n log n), where n is the length of power
    ///     Space complexity - O(m), where m is the number of unique spell damages
    /// </summary>
    /// <param name="power"></param>
    /// <returns></returns>
    public long MaximumTotalDamage(int[] power)
    {
        Array.Sort(power);

        var n = power.Length;

        Span<int> damages = stackalloc int[n];
        Span<int> counts = stackalloc int[n];

        var uniqueCount = 0;

        var current = power[0];
        var count = 1;

        for (var i = 1; i < n; i++)
        {
            if (power[i] == current)
            {
                count++;
            }
            else
            {
                damages[uniqueCount] = current;
                counts[uniqueCount] = count;
                uniqueCount++;

                current = power[i];
                count = 1;
            }
        }

        damages[uniqueCount] = current;
        counts[uniqueCount] = count;

        uniqueCount++;

        Span<long> total = stackalloc long[uniqueCount];

        for (var i = 0; i < uniqueCount; i++)
        {
            total[i] = (long)damages[i] * counts[i];
        }

        Span<long> dp = stackalloc long[uniqueCount];

        dp[0] = total[0];

        for (var i = 1; i < uniqueCount; i++)
        {
            var take = total[i];
            var skip = dp[i - 1];

            var left = 0;
            var right = i - 1;
            var j = -1;

            while (left <= right)
            {
                var mid = left + ((right - left) / 2);

                if (damages[mid] <= damages[i] - 3)
                {
                    j = mid;

                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (j != -1)
            {
                take += dp[j];
            }

            dp[i] = Math.Max(skip, take);
        }

        return dp[uniqueCount - 1];
    }
}