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

namespace LeetCode.Algorithms.CountTheDigitsThatDivideNumber;

/// <inheritdoc />
public class CountTheDigitsThatDivideNumberIterative : ICountTheDigitsThatDivideNumber
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int CountDigits(int num)
    {
        var count = 0;

        var currentNum = num;

        while (currentNum > 0)
        {
            var digit = currentNum % 10;

            if (num % digit == 0)
            {
                count++;
            }

            currentNum /= 10;
        }

        return count;
    }
}