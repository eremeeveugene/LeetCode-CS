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

namespace LeetCode.Algorithms.MinimumTimeToMakeRopeColorful;

/// <inheritdoc />
public sealed class MinimumTimeToMakeRopeColorfulGreedy : IMinimumTimeToMakeRopeColorful
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinCost(string colors, int[] neededTime)
    {
        var totalTime = 0;
        var maxTimeInGroup = neededTime[0];

        for (var i = 1; i < colors.Length; i++)
        {
            var previousColor = colors[i - 1];
            var color = colors[i];

            if (color == previousColor)
            {
                totalTime += Math.Min(neededTime[i], maxTimeInGroup);

                maxTimeInGroup = Math.Max(maxTimeInGroup, neededTime[i]);
            }
            else
            {
                maxTimeInGroup = neededTime[i];
            }
        }

        return totalTime;
    }
}