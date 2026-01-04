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

namespace LeetCode.Algorithms.MinimumOperationsToConvertAllElementsToZero;

/// <inheritdoc />
public class MinimumOperationsToConvertAllElementsToZeroStackAsSpan : IMinimumOperationsToConvertAllElementsToZero
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinOperations(int[] nums)
    {
        Span<int> numsSpan = stackalloc int[nums.Length];

        var numsSpanCount = 0;

        var minOperations = 0;

        foreach (var num in nums)
        {
            while (numsSpanCount > 0 && numsSpan[numsSpanCount - 1] > num)
            {
                numsSpan[numsSpanCount--] = 0;
            }

            if (num == 0)
            {
                continue;
            }

            if (numsSpanCount > 0 && numsSpan[numsSpanCount - 1] >= num)
            {
                continue;
            }

            numsSpan[numsSpanCount++] = num;

            minOperations++;
        }

        return minOperations;
    }
}