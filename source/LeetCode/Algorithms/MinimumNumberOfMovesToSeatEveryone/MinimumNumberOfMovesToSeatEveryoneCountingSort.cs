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

namespace LeetCode.Algorithms.MinimumNumberOfMovesToSeatEveryone;

/// <inheritdoc />
public class MinimumNumberOfMovesToSeatEveryoneCountingSort : IMinimumNumberOfMovesToSeatEveryone
{
    /// <summary>
    ///     Time complexity - O(n + maxPosition)
    ///     Space complexity - O(maxPosition)
    /// </summary>
    /// <param name="seats"></param>
    /// <param name="students"></param>
    /// <returns></returns>
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        var maxPosition = Math.Max(seats.Max(), students.Max());

        var differences = new int[maxPosition];

        foreach (var seat in seats)
        {
            differences[seat - 1]++;
        }

        foreach (var student in students)
        {
            differences[student - 1]--;
        }

        var moves = 0;
        var unmatched = 0;

        foreach (var difference in differences)
        {
            moves += Math.Abs(unmatched);

            unmatched += difference;
        }

        return moves;
    }
}