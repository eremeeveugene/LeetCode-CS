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

namespace LeetCode.Algorithms.NeitherMinimumNorMaximum;

/// <inheritdoc />
public class NeitherMinimumNorMaximumUsingMinMaxComparison : INeitherMinimumNorMaximum
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindNonMinOrMax(int[] nums)
    {
        if (nums.Length < 3)
        {
            return -1;
        }

        var min = Math.Min(nums[0], nums[1]);
        var max = Math.Max(nums[0], nums[1]);

        if (nums[2] > min && nums[2] < max)
        {
            return nums[2];
        }

        return nums[2] < min ? min : max;
    }
}