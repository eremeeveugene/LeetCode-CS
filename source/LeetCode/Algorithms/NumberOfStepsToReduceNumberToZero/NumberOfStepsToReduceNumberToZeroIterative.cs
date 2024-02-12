// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.NumberOfStepsToReduceNumberToZero;

/// <inheritdoc />
public class NumberOfStepsToReduceNumberToZeroIterative : INumberOfStepsToReduceNumberToZero
{
    /// <summary>
    ///     Time complexity - O(log n)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int NumberOfSteps(int num)
    {
        var steps = 0;

        while (num > 0)
        {
            if (num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num--;
            }

            steps++;
        }

        return steps;
    }
}