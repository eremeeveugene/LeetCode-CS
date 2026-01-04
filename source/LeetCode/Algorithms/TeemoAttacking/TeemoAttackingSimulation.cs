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

namespace LeetCode.Algorithms.TeemoAttacking;

/// <inheritdoc />
public class TeemoAttackingSimulation : ITeemoAttacking
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="timeSeries"></param>
    /// <param name="duration"></param>
    /// <returns></returns>
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        var result = duration;

        for (var i = 1; i < timeSeries.Length; i++)
        {
            result += Math.Min(duration, timeSeries[i] - timeSeries[i - 1]);
        }

        return result;
    }
}