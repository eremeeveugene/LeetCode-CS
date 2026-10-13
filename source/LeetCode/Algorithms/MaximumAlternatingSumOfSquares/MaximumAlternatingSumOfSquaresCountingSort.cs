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

namespace LeetCode.Algorithms.MaximumAlternatingSumOfSquares;

/// <inheritdoc />
public sealed class MaximumAlternatingSumOfSquaresCountingSort : IMaximumAlternatingSumOfSquares
{
    private const int MaximumAbsoluteValue = 40_000;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(m)
    /// </remarks>
    public long MaxAlternatingSum(int[] nums)
    {
        var n = nums.Length;

        Span<int> absoluteValueCounts = stackalloc int[MaximumAbsoluteValue + 1];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];
            var absoluteValue = Math.Abs(num);

            absoluteValueCounts[absoluteValue]++;
        }

        var remainingPositiveCount = (n + 1) / 2;

        long result = 0;

        for (var absoluteValue = MaximumAbsoluteValue; absoluteValue >= 0; absoluteValue--)
        {
            var count = absoluteValueCounts[absoluteValue];

            if (count == 0)
            {
                continue;
            }

            var square = (long)absoluteValue * absoluteValue;

            var positiveCount = Math.Min(count, remainingPositiveCount);
            var negativeCount = count - positiveCount;

            remainingPositiveCount -= positiveCount;

            result -= square * negativeCount;
            result += square * positiveCount;
        }

        return result;
    }
}