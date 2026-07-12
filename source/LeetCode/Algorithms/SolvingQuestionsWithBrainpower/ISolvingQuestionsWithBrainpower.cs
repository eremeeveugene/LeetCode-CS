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

namespace LeetCode.Algorithms.SolvingQuestionsWithBrainpower;

/// <summary>
///     https://leetcode.com/problems/solving-questions-with-brainpower/description/
/// </summary>
public interface ISolvingQuestionsWithBrainpower
{
    /// <summary>
    ///     Computes the maximum points obtainable by solving a subset of <paramref name="questions" /> in order,
    ///     where solving a question awards its points but skips a number of subsequent questions equal to its
    ///     brainpower cost.
    /// </summary>
    /// <param name="questions">The array of questions, each specifying points and the number of questions to skip if solved.</param>
    /// <returns>The maximum total points achievable.</returns>
    long MostPoints(int[][] questions);
}