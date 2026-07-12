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

namespace LeetCode.Algorithms.ShortestDistanceToTargetStringInCircularArray;

/// <summary>
///     https://leetcode.com/problems/shortest-distance-to-target-string-in-a-circular-array/description/
/// </summary>
public interface IShortestDistanceToTargetStringInCircularArray
{
    /// <summary>
    ///     Finds the shortest distance, moving in either direction around the circular array
    ///     <paramref name="words" /> starting from <paramref name="startIndex" />, to reach any occurrence of
    ///     <paramref name="target" />.
    /// </summary>
    /// <param name="words">The circular array of strings to search.</param>
    /// <param name="target">The string to find.</param>
    /// <param name="startIndex">The index at which to begin searching.</param>
    /// <returns>The shortest distance to reach <paramref name="target" />, or -1 if it does not occur in <paramref name="words" />.</returns>
    int ClosestTarget(string[] words, string target, int startIndex);
}