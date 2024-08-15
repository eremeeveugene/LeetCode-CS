// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindKthSmallestPairDistance;

/// <inheritdoc />
public class FindKthSmallestPairDistanceBinarySearchWithSlidingWindow : IFindKthSmallestPairDistance
{
    /// <summary>
    ///     Time complexity - O(n log n + n log (max(nums)))
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int SmallestDistancePair(int[] nums, int k)
    {
        Array.Sort(nums);

        var left = 0;
        var right = nums[^1] - nums[0];

        while (left < right)
        {
            var mid = left + ((right - left) / 2);
            var count = CountPairsWithDistanceLessOrEqual(nums, mid);

            if (count >= k)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    private static int CountPairsWithDistanceLessOrEqual(IReadOnlyList<int> nums, int target)
    {
        var count = 0;
        var left = 0;

        for (var right = 1; right < nums.Count; right++)
        {
            while (nums[right] - nums[left] > target)
            {
                left++;
            }

            count += right - left;
        }

        return count;
    }
}