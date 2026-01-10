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

namespace LeetCode.Algorithms.MinimizeTheMaximumDifferenceOfPairs;

/// <inheritdoc />
public sealed class MinimizeTheMaximumDifferenceOfPairsBinarySearch : IMinimizeTheMaximumDifferenceOfPairs
{
    /// <summary>
    ///     Time complexity - O(n log n + n log R), where R = max(nums) - min(nums)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="requiredPairsCount"></param>
    /// <returns></returns>
    public int MinimizeMax(int[] nums, int requiredPairsCount)
    {
        if (requiredPairsCount == 0)
        {
            return 0;
        }

        Array.Sort(nums);

        var low = 0;
        var high = nums[^1] - nums[0];

        while (low < high)
        {
            var mid = low + ((high - low) / 2);

            if (CanFormEnoughPairs(nums, mid, requiredPairsCount))
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;
    }

    private static bool CanFormEnoughPairs(int[] nums, int x, int requiredPairsCount)
    {
        var numsLength = nums.Length;

        var pairsCount = 0;

        for (var i = 0; i < numsLength - 1; i++)
        {
            if (nums[i + 1] - nums[i] > x)
            {
                continue;
            }

            pairsCount++;

            if (pairsCount == requiredPairsCount)
            {
                return true;
            }

            i++;
        }

        return false;
    }
}