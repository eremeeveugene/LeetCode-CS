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

namespace LeetCode.Algorithms.BoatsToSavePeople;

/// <summary>
///     https://leetcode.com/problems/boats-to-save-people/
/// </summary>
public interface IBoatsToSavePeople
{
    /// <summary>
    ///     Computes the minimum number of boats required to carry every person, where each boat carries at most two people
    ///     and their combined weight must not exceed <paramref name="limit" />.
    /// </summary>
    /// <param name="people">The weights of the people to rescue.</param>
    /// <param name="limit">The maximum weight a single boat can carry.</param>
    /// <returns>The minimum number of boats needed to carry every person.</returns>
    int NumRescueBoats(int[] people, int limit);
}