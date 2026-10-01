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

namespace LeetCode.Algorithms.MaximumFrequencyOfAnElementAfterPerformingOperations1;

/// <inheritdoc />
public sealed class MaximumFrequencyOfAnElementAfterPerformingOperations1DifferenceArray : IMaximumFrequencyOfAnElementAfterPerformingOperations1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Counts reachable elements with a difference array over the original value range.
    ///     Existing occurrences need no changes; other reachable elements are limited by the operation count.
    ///     Time complexity - O(n + r), where r is the maximum value minus the minimum value plus one
    ///     Space complexity - O(r)
    /// </remarks>
    public int MaxFrequency(int[] nums, int k, int numOperations)
    {
        var n = nums.Length;

        var minimumValue = int.MaxValue;
        var maximumValue = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            minimumValue = Math.Min(minimumValue, num);
            maximumValue = Math.Max(maximumValue, num);
        }

        var valueRange = maximumValue - minimumValue;

        Span<int> reachabilityDifferences = stackalloc int[valueRange + 2];
        Span<int> valueFrequencies = stackalloc int[valueRange + 1];

        reachabilityDifferences.Clear();
        valueFrequencies.Clear();

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            var valueIndex = num - minimumValue;

            valueFrequencies[valueIndex]++;

            var firstReachableIndex = Math.Max(0, valueIndex - k);
            var afterLastReachableIndex = Math.Min(valueRange + 1, valueIndex + k + 1);

            reachabilityDifferences[firstReachableIndex]++;
            reachabilityDifferences[afterLastReachableIndex]--;
        }

        var maximumFrequency = 0;
        var reachableCount = 0;

        for (var i = 0; i <= valueRange; i++)
        {
            reachableCount += reachabilityDifferences[i];

            var valueFrequency = valueFrequencies[i];
            var reachableFrequency = Math.Min(numOperations, reachableCount - valueFrequency);
            var achievableFrequency = valueFrequency + reachableFrequency;

            maximumFrequency = Math.Max(maximumFrequency, achievableFrequency);
        }

        return maximumFrequency;
    }
}