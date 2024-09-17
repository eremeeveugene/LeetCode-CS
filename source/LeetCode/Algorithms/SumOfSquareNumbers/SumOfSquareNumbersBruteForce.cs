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

namespace LeetCode.Algorithms.SumOfSquareNumbers;

/// <inheritdoc />
public class SumOfSquareNumbersBruteForce : ISumOfSquareNumbers
{
    /// <summary>
    ///     Time complexity - O(c)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    public bool JudgeSquareSum(int c)
    {
        for (long a = 0; a * a <= c; a++)
        {
            for (long b = 0; b * b <= c; b++)
            {
                if ((a * a) + (b * b) == c)
                {
                    return true;
                }
            }
        }

        return false;
    }
}