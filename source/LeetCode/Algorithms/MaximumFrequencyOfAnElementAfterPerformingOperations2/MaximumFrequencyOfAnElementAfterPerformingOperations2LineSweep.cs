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

using System.Runtime.InteropServices;

namespace LeetCode.Algorithms.MaximumFrequencyOfAnElementAfterPerformingOperations2;

/// <inheritdoc />
public sealed class MaximumFrequencyOfAnElementAfterPerformingOperations2LineSweep : IMaximumFrequencyOfAnElementAfterPerformingOperations2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Sweeps sorted range boundaries to count elements that can reach each target value.
    ///     Original values are also included because their existing occurrences need no changes.
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaxFrequency(int[] nums, int k, int numOperations)
    {
        var n = nums.Length;

        var valueToFrequencyDictionary = new Dictionary<int, int>();
        var valueToReachabilityDifferenceDictionary = new Dictionary<int, int>();

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            CollectionsMarshal.GetValueRefOrAddDefault(valueToFrequencyDictionary, num, out _)++;

            var firstReachableValue = num - k;
            var afterLastReachableValue = num + k + 1;

            CollectionsMarshal.GetValueRefOrAddDefault(valueToReachabilityDifferenceDictionary, firstReachableValue, out _)++;
            CollectionsMarshal.GetValueRefOrAddDefault(valueToReachabilityDifferenceDictionary, afterLastReachableValue, out _)--;

            valueToReachabilityDifferenceDictionary.TryAdd(num, 0);
        }

        var targetValues = valueToReachabilityDifferenceDictionary.Keys.ToArray();

        Array.Sort(targetValues);

        var targetCount = targetValues.Length;
        var maximumFrequency = 0;
        var reachableCount = 0;

        for (var i = 0; i < targetCount; i++)
        {
            var targetValue = targetValues[i];

            reachableCount += valueToReachabilityDifferenceDictionary[targetValue];

            var valueFrequency = valueToFrequencyDictionary.GetValueOrDefault(targetValue);
            var reachableFrequency = Math.Min(numOperations, reachableCount - valueFrequency);
            var achievableFrequency = valueFrequency + reachableFrequency;

            maximumFrequency = Math.Max(maximumFrequency, achievableFrequency);
        }

        return maximumFrequency;
    }
}