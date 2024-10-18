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

namespace LeetCode.Algorithms.CountNumberOfMaximumBitwiseORSubsets;

/// <inheritdoc />
public class CountNumberOfMaximumBitwiseORSubsetsBacktracking : ICountNumberOfMaximumBitwiseORSubsets
{
    /// <summary>
    ///     Time complexity - O(2^n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int CountMaxOrSubsets(int[] nums)
    {
        var maxOr = 0;
        var count = 0;

        maxOr = nums.Aggregate(maxOr, (current, num) => current | num);

        CountMaxOrSubsetsHelper(nums, 0, 0, ref maxOr, ref count);

        return count;
    }

    private static void CountMaxOrSubsetsHelper(int[] nums, int index, int currentOr, ref int maxOr, ref int count)
    {
        if (index == nums.Length)
        {
            if (currentOr == maxOr)
            {
                count++;
            }

            return;
        }

        CountMaxOrSubsetsHelper(nums, index + 1, currentOr | nums[index], ref maxOr, ref count);

        CountMaxOrSubsetsHelper(nums, index + 1, currentOr, ref maxOr, ref count);
    }
}