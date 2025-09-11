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

namespace LeetCode.Algorithms.MinimumNumberOfPeopleToTeach;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-people-to-teach/description/
/// </summary>
public interface IMinimumNumberOfPeopleToTeach
{
    int MinimumTeachings(int languagesCount, int[][] languages, int[][] friendships);
}