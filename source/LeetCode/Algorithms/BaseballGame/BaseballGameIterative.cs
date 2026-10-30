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

using System.Globalization;

namespace LeetCode.Algorithms.BaseballGame;

/// <inheritdoc />
public sealed class BaseballGameIterative : IBaseballGame
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int CalPoints(string[] operations)
    {
        var n = operations.Length;

        var scores = new List<int>();

        for (var i = 0; i < n; i++)
        {
            var operation = operations[i];

            switch (operation)
            {
                case "D":
                    scores.Add(scores[^1] * 2);
                    break;
                case "C":
                    scores.RemoveAt(scores.Count - 1);
                    break;
                case "+":
                    scores.Add(scores[^1] + scores[^2]);
                    break;
                default:
                    scores.Add(int.Parse(operation, CultureInfo.InvariantCulture));
                    break;
            }
        }

        var m = scores.Count;

        var totalScore = 0;

        for (var i = 0; i < m; i++)
        {
            totalScore += scores[i];
        }

        return totalScore;
    }
}