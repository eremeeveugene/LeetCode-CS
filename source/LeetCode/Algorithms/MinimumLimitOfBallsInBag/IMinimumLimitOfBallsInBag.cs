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

namespace LeetCode.Algorithms.MinimumLimitOfBallsInBag;

/// <summary>
///     https://leetcode.com/problems/minimum-limit-of-balls-in-a-bag/description/
/// </summary>
public interface IMinimumLimitOfBallsInBag
{
    /// <summary>
    ///     Splits the bags of balls in <paramref name="nums" /> into smaller bags using at most
    ///     <paramref name="maxOperations" /> split operations to minimize the maximum number of balls in any bag.
    /// </summary>
    /// <param name="nums">The array containing the number of balls in each bag.</param>
    /// <param name="maxOperations">The maximum number of split operations allowed.</param>
    /// <returns>The minimum possible value of the maximum number of balls in a bag.</returns>
    int MinimumSize(int[] nums, int maxOperations);
}