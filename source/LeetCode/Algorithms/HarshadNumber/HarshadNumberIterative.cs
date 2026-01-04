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

namespace LeetCode.Algorithms.HarshadNumber;

/// <inheritdoc />
public class HarshadNumberIterative : IHarshadNumber
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public int SumOfTheDigitsOfHarshadNumber(int x)
    {
        var sum = 0;

        var number = x;

        while (number > 0)
        {
            sum += number % 10;

            number /= 10;
        }

        if (sum == 0 || x % sum != 0)
        {
            return -1;
        }

        return sum;
    }
}