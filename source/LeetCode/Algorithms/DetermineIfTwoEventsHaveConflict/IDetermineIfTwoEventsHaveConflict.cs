// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.DetermineIfTwoEventsHaveConflict;

/// <summary>
///     https://leetcode.com/problems/determine-if-two-events-have-conflict/description/
/// </summary>
public interface IDetermineIfTwoEventsHaveConflict
{
    bool HaveConflict(string[] event1, string[] event2);
}