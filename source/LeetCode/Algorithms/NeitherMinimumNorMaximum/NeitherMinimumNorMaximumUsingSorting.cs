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

/// <summary>
///     https://leetcode.com/problems/neither-minimum-nor-maximum/description/
/// </summary>
public static class NeitherMinimumNorMaximumUsingSorting
{
    /// <summary>
    ///     Time complexity - O(n log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int GetResult(int[] nums)
    {
        if (nums.Length < 3)
        {
            return -1;
        }

        Array.Sort(nums);

        return nums[1];
    }
}