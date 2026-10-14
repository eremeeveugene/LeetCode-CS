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

namespace LeetCode.Algorithms.MinimumNumberOfMovesToSeatEveryone;

/// <inheritdoc />
public sealed class MinimumNumberOfMovesToSeatEveryoneCountingSort : IMinimumNumberOfMovesToSeatEveryone
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + maxPosition)
    ///     Space complexity - O(maxPosition)
    /// </remarks>
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        var maxPosition = 0;

        for (var i = 0; i < seats.Length; i++)
        {
            maxPosition = Math.Max(maxPosition, Math.Max(seats[i], students[i]));
        }

        var differences = new int[maxPosition];

        for (var i = 0; i < seats.Length; i++)
        {
            var seat = seats[i];

            differences[seat - 1]++;
        }

        for (var i = 0; i < students.Length; i++)
        {
            var student = students[i];

            differences[student - 1]--;
        }

        var moves = 0;
        var unmatched = 0;

        for (var i = 0; i < differences.Length; i++)
        {
            var difference = differences[i];

            moves += Math.Abs(unmatched);

            unmatched += difference;
        }

        return moves;
    }
}