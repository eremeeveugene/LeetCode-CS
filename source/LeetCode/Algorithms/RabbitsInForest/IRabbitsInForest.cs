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

namespace LeetCode.Algorithms.RabbitsInForest;

/// <summary>
///     https://leetcode.com/problems/rabbits-in-forest/description/
/// </summary>
public interface IRabbitsInForest
{
    /// <summary>
    ///     Determines the minimum number of rabbits that could be in the forest given the responses in
    ///     <paramref name="answers" />, where each rabbit reports how many other rabbits share its color.
    /// </summary>
    /// <param name="answers">The array of responses collected from asking every rabbit.</param>
    /// <returns>The minimum possible total number of rabbits in the forest.</returns>
    int NumRabbits(int[] answers);
}