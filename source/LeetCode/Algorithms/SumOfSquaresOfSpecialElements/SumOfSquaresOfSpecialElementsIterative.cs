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

namespace LeetCode.Algorithms.SumOfSquaresOfSpecialElements;

/// <inheritdoc />
public sealed class SumOfSquaresOfSpecialElementsIterative : ISumOfSquaresOfSpecialElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SumOfSquares(int[] nums)
    {
        var n = nums.Length;

        var result = 0;

        for (var i = 1; i <= n; i++)
        {
            if (n % i != 0)
            {
                continue;
            }

            var num = nums[i - 1];

            result += num * num;
        }

        return result;
    }
}