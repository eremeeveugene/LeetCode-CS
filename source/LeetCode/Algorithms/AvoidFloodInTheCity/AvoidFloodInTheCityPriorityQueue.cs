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

namespace LeetCode.Algorithms.AvoidFloodInTheCity;

/// <inheritdoc />
public sealed class AvoidFloodInTheCityPriorityQueue : IAvoidFloodInTheCity
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] AvoidFlood(int[] rains)
    {
        var n = rains.Length;

        Span<int> nextRainDays = stackalloc int[n];

        FillNextRainDays(rains, nextRainDays);

        var fullLakesHashSet = new HashSet<int>();
        var lakesToDryPriorityQueue = new PriorityQueue<int, int>();

        for (var day = 0; day < n; day++)
        {
            var lake = rains[day];

            if (lake == 0)
            {
                rains[day] = lakesToDryPriorityQueue.Count > 0 ? lakesToDryPriorityQueue.Dequeue() : 1;

                fullLakesHashSet.Remove(rains[day]);

                continue;
            }

            if (!fullLakesHashSet.Add(lake))
            {
                return [];
            }

            rains[day] = -1;

            var nextRainDay = nextRainDays[day];

            if (nextRainDay < n)
            {
                lakesToDryPriorityQueue.Enqueue(lake, nextRainDay);
            }
        }

        return rains;
    }

    /// <summary>
    ///     Fills each rainy day's next rainfall day for the same lake.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    /// <param name="rains">The rainfall schedule.</param>
    /// <param name="nextRainDays">The destination for the next rainfall days.</param>
    private static void FillNextRainDays(int[] rains, Span<int> nextRainDays)
    {
        var n = rains.Length;

        nextRainDays.Fill(n);

        var lakeToNextRainDayDictionary = new Dictionary<int, int>();

        for (var day = n - 1; day >= 0; day--)
        {
            var lake = rains[day];

            if (lake == 0)
            {
                continue;
            }

            if (lakeToNextRainDayDictionary.TryGetValue(lake, out var nextRainDay))
            {
                nextRainDays[day] = nextRainDay;
            }

            lakeToNextRainDayDictionary[lake] = day;
        }
    }
}