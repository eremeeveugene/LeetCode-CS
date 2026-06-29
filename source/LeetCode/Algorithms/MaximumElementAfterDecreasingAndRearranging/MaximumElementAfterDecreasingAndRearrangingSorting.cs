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

namespace LeetCode.Algorithms.MaximumElementAfterDecreasingAndRearranging;

/// <inheritdoc />
public sealed class MaximumElementAfterDecreasingAndRearrangingSorting : IMaximumElementAfterDecreasingAndRearranging
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        var n = arr.Length;

        Array.Sort(arr);

        var result = 1;

        for (var i = 1; i < n; i++)
        {
            if (arr[i] >= result + 1)
            {
                result++;
            }
        }

        return result;
    }
}