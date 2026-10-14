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

namespace LeetCode.Algorithms.CountSubarraysWhereMaxElementAppearsAtLeastKTimes;

/// <inheritdoc />
public sealed class CountSubarraysWhereMaxElementAppearsAtLeastKTimesRecursive : ICountSubarraysWhereMaxElementAppearsAtLeastKTimes
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n^2)
    /// </remarks>
    public long CountSubarrays(int[] nums, int k)
    {
        var n = nums.Length;
        var maxElement = nums[0];

        for (var i = 1; i < n; i++)
        {
            maxElement = Math.Max(maxElement, nums[i]);
        }

        var maxElementCount = 0;

        for (var i = 0; i < n; i++)
        {
            if (nums[i] == maxElement)
            {
                maxElementCount++;
            }
        }

        var visited = new bool[n + 1, n + 1];

        return CountSubarrays(nums, k, maxElement, 0, n, maxElementCount, visited);
    }

    private static long CountSubarrays(int[] nums, int k, int maxElement, int left, int right, int maxElementCount, bool[,] visited)
    {
        if (left >= right || visited[left, right])
        {
            return 0;
        }

        visited[left, right] = true;

        var result = maxElementCount >= k ? 1L : 0L;

        var withoutLeftCount = nums[left] == maxElement ? maxElementCount - 1 : maxElementCount;
        var withoutRightCount = nums[right - 1] == maxElement ? maxElementCount - 1 : maxElementCount;

        return result +
               CountSubarrays(nums, k, maxElement, left + 1, right, withoutLeftCount, visited) +
               CountSubarrays(nums, k, maxElement, left, right - 1, withoutRightCount, visited);
    }
}