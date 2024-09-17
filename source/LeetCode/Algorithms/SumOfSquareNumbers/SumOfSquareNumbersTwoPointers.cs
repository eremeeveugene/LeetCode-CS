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
public class SumOfSquareNumbersTwoPointers : ISumOfSquareNumbers
{
    /// <summary>
    ///     Time complexity - O(Sqrt(c))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    public bool JudgeSquareSum(int c)
    {
        long left = 0;
        var right = (long)Math.Sqrt(c);

        while (left <= right)
        {
            var root = (left * left) + (right * right);

            if (root == c)
            {
                return true;
            }

            if (root > c)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return false;
    }
}