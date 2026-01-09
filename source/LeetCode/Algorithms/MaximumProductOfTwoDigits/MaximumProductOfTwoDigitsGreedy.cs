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

namespace LeetCode.Algorithms.MaximumProductOfTwoDigits;

/// <inheritdoc />
public class MaximumProductOfTwoDigitsGreedy : IMaximumProductOfTwoDigits
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int MaxProduct(int n)
    {
        var max = 0;
        var secondMax = 0;

        while (n > 0)
        {
            var number = n % 10;

            if (number > max)
            {
                secondMax = max;
                max = number;
            }
            else if (number > secondMax)
            {
                secondMax = number;
            }

            n /= 10;
        }

        return max * secondMax;
    }
}