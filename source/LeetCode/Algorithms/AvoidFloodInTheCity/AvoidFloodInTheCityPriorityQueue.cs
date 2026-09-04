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

        var fullLakesHashSet = new HashSet<int>();
        var lakesToDryPriorityQueue = new PriorityQueue<int, int>();

        for (var day = 0; day < n; day++)
        {
            var lake = rains[day];

            if (lake == 0)
            {
                if (lakesToDryPriorityQueue.Count > 0)
                {
                    var lakeToDry = lakesToDryPriorityQueue.Dequeue();

                    rains[day] = lakeToDry;
                }
                else
                {
                    rains[day] = 1;
                }

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
}