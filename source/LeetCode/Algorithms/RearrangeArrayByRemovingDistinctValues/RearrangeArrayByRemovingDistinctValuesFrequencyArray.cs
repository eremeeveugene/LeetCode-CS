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
public sealed class RearrangeArrayByRemovingDistinctValuesFrequencyArray : IRearrangeArrayByRemovingDistinctValues
{
    private const int MaxValue = 100;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(m)
    /// </remarks>
    public int[] RearrangeArray(int[] nums)
    {
        var n = nums.Length;

        Span<int> numsFrequencies = stackalloc int[MaxValue + 1];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            numsFrequencies[num]++;
        }

        Span<int> activeValues = stackalloc int[MaxValue + 1];

        var activeValuesCount = 0;

        for (var value = 1; value <= MaxValue; value++)
        {
            if (numsFrequencies[value] == 0)
            {
                continue;
            }

            activeValues[activeValuesCount] = value;

            activeValuesCount++;
        }

        var writeIndex = 0;

        while (activeValuesCount > 0)
        {
            var nextActiveValuesCount = 0;

            for (var i = 0; i < activeValuesCount; i++)
            {
                var value = activeValues[i];

                nums[writeIndex] = value;

                writeIndex++;

                numsFrequencies[value]--;

                if (numsFrequencies[value] == 0)
                {
                    continue;
                }

                activeValues[nextActiveValuesCount] = value;

                nextActiveValuesCount++;
            }

            activeValuesCount = nextActiveValuesCount;
        }

        return nums;
    }
}