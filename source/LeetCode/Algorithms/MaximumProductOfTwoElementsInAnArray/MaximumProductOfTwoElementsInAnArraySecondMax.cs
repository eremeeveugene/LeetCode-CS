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

namespace LeetCode.Algorithms.MaximumProductOfTwoElementsInAnArray;

/// <inheritdoc />
public sealed class MaximumProductOfTwoElementsInAnArraySecondMax : IMaximumProductOfTwoElementsInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxProduct(int[] nums)
    {
        var firstMax = 0;
        var secondMax = 0;

        foreach (var num in nums)
        {
            if (num > firstMax)
            {
                secondMax = firstMax;
                firstMax = num;
            }
            else
            {
                secondMax = Math.Max(secondMax, num);
            }
        }

        return (firstMax - 1) * (secondMax - 1);
    }
}