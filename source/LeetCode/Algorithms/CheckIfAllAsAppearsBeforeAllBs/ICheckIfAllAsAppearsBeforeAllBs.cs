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

namespace LeetCode.Algorithms.CheckIfAllAsAppearsBeforeAllBs;

/// <summary>
///     https://leetcode.com/problems/check-if-all-as-appears-before-all-bs/description/
/// </summary>
public interface ICheckIfAllAsAppearsBeforeAllBs
{
    /// <summary>
    ///     Determines whether every 'a' in <paramref name="s" /> appears before every 'b'.
    /// </summary>
    /// <param name="s">The string consisting only of the characters 'a' and 'b'.</param>
    /// <returns><c>true</c> if every 'a' appears before every 'b'; otherwise, <c>false</c>.</returns>
    bool CheckString(string s);
}