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

namespace LeetCode.Algorithms.ScoreValidator;

/// <inheritdoc />
public sealed class ScoreValidatorSimulation : IScoreValidator
{
    private const int MaxCounter = 10;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] ScoreValidator(string[] events)
    {
        var n = events.Length;

        var score = 0;
        var counter = 0;

        for (var i = 0; i < n && counter < MaxCounter; i++)
        {
            var currentEvent = events[i];

            switch (currentEvent)
            {
                case "W":
                    counter++;
                    break;
                case "WD":
                case "NB":
                    score++;
                    break;
                default:
                    var digit = GetDigit(currentEvent[0]);

                    score += digit;
                    break;
            }
        }

        return [score, counter];
    }

    /// <summary>
    ///     Converts a digit character to its numeric value.
    /// </summary>
    /// <param name="c">The digit character.</param>
    /// <returns>The numeric value of the digit.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetDigit(char c)
    {
        return c - '0';
    }
}