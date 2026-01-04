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

namespace LeetCode.Algorithms.MinimumNumberOfOperationsToMoveAllBallsToEachBox;

/// <inheritdoc />
public class MinimumNumberOfOperationsToMoveAllBallsToEachBoxTwoPass : IMinimumNumberOfOperationsToMoveAllBallsToEachBox
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="boxes"></param>
    /// <returns></returns>
    public int[] MinOperations(string boxes)
    {
        var result = new int[boxes.Length];

        var count = 0;
        var moves = 0;

        for (var i = 0; i < boxes.Length; i++)
        {
            result[i] += moves;

            if (boxes[i] == '1')
            {
                count++;
            }

            moves += count;
        }

        count = 0;
        moves = 0;

        for (var i = boxes.Length - 1; i >= 0; i--)
        {
            result[i] += moves;

            if (boxes[i] == '1')
            {
                count++;
            }

            moves += count;
        }

        return result;
    }
}