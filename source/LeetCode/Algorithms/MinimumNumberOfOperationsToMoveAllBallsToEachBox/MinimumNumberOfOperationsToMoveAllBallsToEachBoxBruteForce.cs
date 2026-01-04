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
public class MinimumNumberOfOperationsToMoveAllBallsToEachBoxBruteForce :
    IMinimumNumberOfOperationsToMoveAllBallsToEachBox
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="boxes"></param>
    /// <returns></returns>
    public int[] MinOperations(string boxes)
    {
        var result = new int[boxes.Length];

        for (var i = 0; i < boxes.Length; i++)
        {
            for (var j = 0; j < boxes.Length; j++)
            {
                if (boxes[j] == '1' && i != j)
                {
                    result[i] += Math.Abs(j - i);
                }
            }
        }

        return result;
    }
}