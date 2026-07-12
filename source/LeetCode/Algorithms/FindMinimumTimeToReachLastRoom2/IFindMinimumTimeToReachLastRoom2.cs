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

namespace LeetCode.Algorithms.FindMinimumTimeToReachLastRoom2;

/// <summary>
///     https://leetcode.com/problems/find-minimum-time-to-reach-last-room-ii/description/
/// </summary>
public interface IFindMinimumTimeToReachLastRoom2
{
    /// <summary>
    ///     Finds the minimum time to reach the bottom-right room of the dungeon starting from the top-left room, where
    ///     <paramref name="moveTime" />[i][j] is the earliest time the room (i, j) can be entered and moves alternately
    ///     take one and two seconds.
    /// </summary>
    /// <param name="moveTime">The matrix of the earliest times at which each room can be entered.</param>
    /// <returns>The minimum time in seconds required to reach the last room.</returns>
    int MinTimeToReach(int[][] moveTime);
}