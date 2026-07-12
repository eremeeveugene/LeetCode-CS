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

namespace LeetCode.Algorithms.MinimumNumberOfArrowsToBurstBalloons;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/
/// </summary>
public interface IMinimumNumberOfArrowsToBurstBalloons
{
    /// <summary>
    ///     Finds the minimum number of arrows, each fired straight up and bursting every balloon whose horizontal
    ///     diameter interval in <paramref name="points" /> it passes through, needed to burst all balloons.
    /// </summary>
    /// <param name="points">The array of [start, end] horizontal diameter intervals of the balloons.</param>
    /// <returns>The minimum number of arrows required to burst all balloons.</returns>
    int FindMinArrowShots(int[][] points);
}