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

namespace LeetCode.Algorithms.OpenTheLock;

/// <summary>
///     https://leetcode.com/problems/open-the-lock/
/// </summary>
public interface IOpenTheLock
{
    /// <summary>
    ///     Finds the minimum number of single-wheel turns needed to change a 4-wheel combination lock from "0000" to
    ///     <paramref name="target" />, without ever passing through any of the combinations in
    ///     <paramref name="deadends" />.
    /// </summary>
    /// <param name="deadends">The list of combinations that, if reached, lock the wheels and prevent further turns.</param>
    /// <param name="target">The combination the lock should reach.</param>
    /// <returns>The minimum number of turns required to reach <paramref name="target" />, or -1 if it is impossible.</returns>
    int OpenLock(string[] deadends, string target);
}