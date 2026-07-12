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

namespace LeetCode.Algorithms.FindTheTownJudge;

/// <summary>
///     https://leetcode.com/problems/find-the-town-judge/description/
/// </summary>
public interface IFindTheTownJudge
{
    /// <summary>
    ///     Finds the town judge among <paramref name="n" /> people, where the judge is trusted by everybody else and
    ///     trusts nobody, based on the trust relationships in <paramref name="trust" />.
    /// </summary>
    /// <param name="n">The number of people in the town, labeled from 1 to <paramref name="n" />.</param>
    /// <param name="trust">The trust relationships, where each pair [a, b] means person a trusts person b.</param>
    /// <returns>The label of the town judge, or -1 if no such person exists.</returns>
    int FindJudge(int n, int[][] trust);
}