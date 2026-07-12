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

namespace LeetCode.Algorithms.NumberOfPeopleAwareOfSecret;

/// <summary>
///     https://leetcode.com/problems/number-of-people-aware-of-a-secret/description/
/// </summary>
public interface INumberOfPeopleAwareOfSecret
{
    /// <summary>
    ///     Computes how many people know the secret on day <paramref name="n" />, given that a person shares the
    ///     secret with a new person every day starting <paramref name="delay" /> days after learning it, and forgets
    ///     it after <paramref name="forget" /> days.
    /// </summary>
    /// <param name="n">The day on which to count how many people know the secret.</param>
    /// <param name="delay">The number of days after learning the secret before a person starts sharing it.</param>
    /// <param name="forget">The number of days after learning the secret before a person forgets it.</param>
    /// <returns>The number of people who know the secret on day <paramref name="n" />, modulo 10^9 + 7.</returns>
    int PeopleAwareOfSecret(int n, int delay, int forget);
}