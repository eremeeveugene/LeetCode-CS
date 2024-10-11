// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.TheNumberOfTheSmallestUnoccupiedChair;

/// <inheritdoc />
public class TheNumberOfTheSmallestUnoccupiedChairPriorityQueue : ITheNumberOfTheSmallestUnoccupiedChair
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="times"></param>
    /// <param name="targetFriend"></param>
    /// <returns></returns>
    public int SmallestChair(int[][] times, int targetFriend)
    {
        var targetFriendArrival = times[targetFriend][0];

        Array.Sort(times, (a, b) => a[0] - b[0]);

        var availablePriorityQueue = new PriorityQueue<int, int>();
        var occupiedPriorityQueue = new PriorityQueue<(int Chair, int Leaving), int>();

        var currentChair = 0;

        foreach (var time in times)
        {
            var arrival = time[0];
            var leaving = time[1];

            while (occupiedPriorityQueue.Count > 0 && occupiedPriorityQueue.Peek().Leaving <= arrival)
            {
                var availableChair = occupiedPriorityQueue.Dequeue().Chair;

                availablePriorityQueue.Enqueue(availableChair, availableChair);
            }

            var nextChair = availablePriorityQueue.Count == 0 ? currentChair++ : availablePriorityQueue.Dequeue();

            if (arrival == targetFriendArrival)
            {
                return nextChair;
            }

            occupiedPriorityQueue.Enqueue((nextChair, leaving), leaving);
        }

        return -1;
    }
}