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

namespace LeetCode.Algorithms.NumberOfSmoothDescentPeriodsOfStock;

/// <inheritdoc />
public sealed class NumberOfSmoothDescentPeriodsOfStockTwoPointers : INumberOfSmoothDescentPeriodsOfStock
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    public long GetDescentPeriods(int[] prices)
    {
        long result = 1;

        var left = 0;

        for (var right = 1; right < prices.Length; right++)
        {
            var previous = prices[right - 1];
            var current = prices[right];

            if (previous - current == 1)
            {
                result += right - left + 1;
            }
            else
            {
                left = right;

                result++;
            }
        }

        return result;
    }
}