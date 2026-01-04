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

/// <inheritdoc />
public class SolvingQuestionsWithBrainpowerDynamicProgramming : ISolvingQuestionsWithBrainpower
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="questions"></param>
    /// <returns></returns>
    public long MostPoints(int[][] questions)
    {
        var maximumPoints = new long[questions.Length];

        for (var currentQuestionIndex = questions.Length - 1; currentQuestionIndex >= 0; currentQuestionIndex--)
        {
            var currentQuestionPoints = questions[currentQuestionIndex][0];
            var currentQuestionBrainpower = questions[currentQuestionIndex][1];
            var nextSolvableQuestionIndex = currentQuestionIndex + currentQuestionBrainpower + 1;

            long solvePoints = currentQuestionPoints;

            if (nextSolvableQuestionIndex < questions.Length)
            {
                solvePoints += maximumPoints[nextSolvableQuestionIndex];
            }

            long skipPoints = 0;

            var nextQuestionIndex = currentQuestionIndex + 1;

            if (nextQuestionIndex < questions.Length)
            {
                skipPoints += maximumPoints[nextQuestionIndex];
            }

            maximumPoints[currentQuestionIndex] = Math.Max(solvePoints, skipPoints);
        }

        return maximumPoints[0];
    }
}