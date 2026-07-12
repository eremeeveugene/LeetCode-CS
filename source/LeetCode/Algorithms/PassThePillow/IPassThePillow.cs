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

namespace LeetCode.Algorithms.PassThePillow;

/// <summary>
///     https://leetcode.com/problems/pass-the-pillow/
/// </summary>
public interface IPassThePillow
{
    /// <summary>
    ///     Determines which of the <paramref name="n" /> people numbered 1 to <paramref name="n" /> is holding the pillow
    ///     after <paramref name="time" /> seconds, given that the pillow is passed each second and reverses direction upon
    ///     reaching either end.
    /// </summary>
    /// <param name="n">The number of people passing the pillow.</param>
    /// <param name="time">The number of seconds that elapse.</param>
    /// <returns>The number of the person holding the pillow after <paramref name="time" /> seconds.</returns>
    int PassThePillow(int n, int time);
}