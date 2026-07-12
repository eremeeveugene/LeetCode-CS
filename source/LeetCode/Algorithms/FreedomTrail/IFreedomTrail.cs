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

namespace LeetCode.Algorithms.FreedomTrail;

/// <summary>
///     https://leetcode.com/problems/freedom-trail/description/
/// </summary>
public interface IFreedomTrail
{
    /// <summary>
    ///     Computes the minimum number of steps to spell out <paramref name="key" /> by rotating <paramref name="ring" /> so each required character aligns with the pointer, then pressing the button to confirm it.
    /// </summary>
    /// <param name="ring">The rotatable ring of characters.</param>
    /// <param name="key">The string that must be spelled out using the ring.</param>
    /// <returns>The minimum total number of steps required to spell <paramref name="key" />.</returns>
    int FindRotateSteps(string ring, string key);
}