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

namespace LeetCode.Algorithms.FindScoreOfAnArrayAfterMarkingAllElements;

/// <summary>
///     https://leetcode.com/problems/find-score-of-an-array-after-marking-all-elements/description/
/// </summary>
public interface IFindScoreOfAnArrayAfterMarkingAllElements
{
    /// <summary>
    ///     Repeatedly picks the smallest unmarked element (leftmost on ties) in <paramref name="nums" />, adds its value to the score, and marks it along with its adjacent elements, until all elements are marked.
    /// </summary>
    /// <param name="nums">The array of integers to process.</param>
    /// <returns>The total score accumulated after marking all elements.</returns>
    long FindScore(int[] nums);
}