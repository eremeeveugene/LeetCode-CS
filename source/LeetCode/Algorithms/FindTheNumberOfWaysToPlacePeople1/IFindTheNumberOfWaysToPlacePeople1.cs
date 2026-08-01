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

namespace LeetCode.Algorithms.FindTheNumberOfWaysToPlacePeople1;

/// <summary>
///     https://leetcode.com/problems/find-the-number-of-ways-to-place-people-i/description/
/// </summary>
public interface IFindTheNumberOfWaysToPlacePeople1
{
    /// <summary>
    ///     Counts the number of ways to choose two points from <paramref name="points" /> such that one point (Alice's) is the upper-left corner and the
    ///     other (Bob's) is the lower-right corner of a rectangle containing no other point strictly inside or on its boundary.
    /// </summary>
    /// <param name="points">The array of 2D points, each represented as a coordinate pair.</param>
    /// <returns>The number of valid pairs of points.</returns>
    int NumberOfPairs(int[][] points);
}