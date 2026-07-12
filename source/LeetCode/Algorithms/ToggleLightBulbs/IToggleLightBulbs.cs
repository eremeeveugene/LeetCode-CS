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

namespace LeetCode.Algorithms.ToggleLightBulbs;

/// <summary>
///     https://leetcode.com/problems/toggle-light-bulbs/description/
/// </summary>
public interface IToggleLightBulbs
{
    /// <summary>
    ///     Determines the final state of each light bulb in <paramref name="bulbs" /> after applying the
    ///     encoded sequence of toggle operations.
    /// </summary>
    /// <param name="bulbs">The initial states of the light bulbs, encoding the toggle operations to apply.</param>
    /// <returns>A list representing the final state of each light bulb.</returns>
    IList<int> ToggleLightBulbs(IList<int> bulbs);
}