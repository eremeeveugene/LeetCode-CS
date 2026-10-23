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

namespace LeetCode.Algorithms.RearrangeArrayByRemovingDistinctValues;

/// <inheritdoc />
public sealed class RearrangeArrayByRemovingDistinctValuesCounting : IRearrangeArrayByRemovingDistinctValues
{
    private const int MaxValue = 100;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(m)
    /// </remarks>
    public int[] RearrangeArray(int[] nums)
    {
        var n = nums.Length;

        Span<int> counts = stackalloc int[MaxValue + 1];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            counts[num]++;
        }

        var result = new int[n];

        var resultIndex = 0;

        while (resultIndex < n)
        {
            for (var value = 1; value <= MaxValue; value++)
            {
                if (counts[value] == 0)
                {
                    continue;
                }

                counts[value]--;

                result[resultIndex] = value;

                resultIndex++;
            }
        }

        return result;
    }
}