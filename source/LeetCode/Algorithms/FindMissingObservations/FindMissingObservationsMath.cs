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

namespace LeetCode.Algorithms.FindMissingObservations;

/// <inheritdoc />
public class FindMissingObservationsMath : IFindMissingObservations
{
    /// <summary>
    ///     Time complexity - O(m + n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="rolls"></param>
    /// <param name="mean"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] MissingRolls(int[] rolls, int mean, int n)
    {
        var missingSum = (mean * (rolls.Length + n)) - rolls.Sum();

        if (missingSum < n || missingSum > n * 6)
        {
            return [];
        }

        var result = new int[n];

        var baseValue = missingSum / n;
        var remainder = missingSum - (baseValue * n);

        for (var i = 0; i < n; i++)
        {
            result[i] = baseValue;

            if (remainder <= 0)
            {
                continue;
            }

            result[i]++;

            remainder--;
        }

        return result;
    }
}