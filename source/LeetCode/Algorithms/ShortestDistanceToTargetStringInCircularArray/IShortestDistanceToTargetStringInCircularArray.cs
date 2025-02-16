// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
    int ClosetTarget(string[] words, string target, int startIndex);
}