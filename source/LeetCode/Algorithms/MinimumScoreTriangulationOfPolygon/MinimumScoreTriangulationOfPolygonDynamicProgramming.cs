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

namespace LeetCode.Algorithms.MinimumScoreTriangulationOfPolygon;

/// <inheritdoc />
public sealed class MinimumScoreTriangulationOfPolygonDynamicProgramming : IMinimumScoreTriangulationOfPolygon
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(n^2)
    /// </remarks>
    public int MinScoreTriangulation(int[] values)
    {
        var n = values.Length;

        var minimumScores = new int[n, n];

        for (var length = 2; length < n; length++)
        {
            for (var left = 0; left + length < n; left++)
            {
                var leftValue = values[left];

                var right = left + length;
                var rightValue = values[right];

                var minimumScore = int.MaxValue;

                for (var middle = left + 1; middle < right; middle++)
                {
                    var middleValue = values[middle];

                    var leftSubpolygonScore = minimumScores[left, middle];
                    var triangleScore = leftValue * middleValue * rightValue;
                    var rightSubpolygonScore = minimumScores[middle, right];

                    var score = leftSubpolygonScore + triangleScore + rightSubpolygonScore;

                    minimumScore = Math.Min(minimumScore, score);
                }

                minimumScores[left, right] = minimumScore;
            }
        }

        return minimumScores[0, n - 1];
    }
}