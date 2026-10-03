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

namespace LeetCode.Algorithms.MaximumFrequencyOfAnElementAfterPerformingOperations2;

/// <inheritdoc />
public sealed class MaximumFrequencyOfAnElementAfterPerformingOperations2SlidingWindow : IMaximumFrequencyOfAnElementAfterPerformingOperations2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Sorts the input array in place and advances windows for arbitrary targets and existing target values.
    ///     A window of width at most 2k can reach a common target; existing target occurrences need no changes.
    ///     Each window boundary moves only forward, so the scan after sorting takes O(n) time and O(1) space.
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n), including the sorting stack
    /// </remarks>
    public int MaxFrequency(int[] nums, int k, int numOperations)
    {
        var n = nums.Length;

        Array.Sort(nums);

        var maximumWindowWidth = 2L * k;
        var commonTargetLeftIndex = 0;
        var reachableLeftIndex = 0;
        var reachableRightIndex = 0;
        var maximumFrequency = 0;
        var groupStartIndex = 0;

        while (groupStartIndex < n)
        {
            var targetValue = nums[groupStartIndex];
            var groupEndIndex = groupStartIndex + 1;

            while (groupEndIndex < n && nums[groupEndIndex] == targetValue)
            {
                groupEndIndex++;
            }

            while ((long)targetValue - nums[commonTargetLeftIndex] > maximumWindowWidth)
            {
                commonTargetLeftIndex++;
            }

            var commonTargetCount = groupEndIndex - commonTargetLeftIndex;
            var commonTargetFrequency = Math.Min(commonTargetCount, numOperations);

            maximumFrequency = Math.Max(maximumFrequency, commonTargetFrequency);

            var minimumReachableValue = (long)targetValue - k;
            var maximumReachableValue = (long)targetValue + k;

            while (nums[reachableLeftIndex] < minimumReachableValue)
            {
                reachableLeftIndex++;
            }

            while (reachableRightIndex < n && nums[reachableRightIndex] <= maximumReachableValue)
            {
                reachableRightIndex++;
            }

            var reachableCount = reachableRightIndex - reachableLeftIndex;
            var valueFrequency = groupEndIndex - groupStartIndex;
            var achievableFrequency = Math.Min(reachableCount, valueFrequency + numOperations);

            maximumFrequency = Math.Max(maximumFrequency, achievableFrequency);

            if (maximumFrequency == n)
            {
                return maximumFrequency;
            }

            groupStartIndex = groupEndIndex;
        }

        return maximumFrequency;
    }
}