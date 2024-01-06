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

namespace LeetCode.Algorithms.ThirdMaximumNumber;

/// <summary>
///     https://leetcode.com/problems/third-maximum-number/description/
/// </summary>
public static class ThirdMaximumNumberDistinctOrder
{
    /// <summary>
    ///     Time complexity - O (n log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int GetResult(int[] nums)
    {
        var numsLength = nums.Length;

        switch (numsLength)
        {
            case 1:
                return nums[0];
            case 2:
                return Math.Max(nums[0], nums[1]);
        }

        var distinct = nums.Distinct().Order().ToArray();

        var distinctLength = distinct.Length;

        return distinctLength < 3 ? distinct.Last() : distinct[distinctLength - 3];
    }
}