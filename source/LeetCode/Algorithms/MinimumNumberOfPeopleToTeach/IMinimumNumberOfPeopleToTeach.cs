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

namespace LeetCode.Algorithms.MinimumNumberOfPeopleToTeach;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-people-to-teach/description/
/// </summary>
public interface IMinimumNumberOfPeopleToTeach
{
    /// <summary>
    ///     Chooses one of the <paramref name="languagesCount" /> available languages to teach to the minimum number
    ///     of users so that every friend pair in <paramref name="friendships" /> shares a common language, given
    ///     each user's known languages in <paramref name="languages" />.
    /// </summary>
    /// <param name="languagesCount">The total number of available languages, numbered from 1.</param>
    /// <param name="languages">The list of languages known by each user.</param>
    /// <param name="friendships">The list of friend pairs, given as 1-indexed user ids.</param>
    /// <returns>The minimum number of users that need to be taught the chosen language.</returns>
    int MinimumTeachings(int languagesCount, int[][] languages, int[][] friendships);
}