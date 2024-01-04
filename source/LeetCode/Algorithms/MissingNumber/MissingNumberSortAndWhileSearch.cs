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

namespace LeetCode.Algorithms.MissingNumber;

/// <summary>
///     https://leetcode.com/problems/missing-number/description/
/// </summary>
public static class MissingNumberSortAndWhileSearch
{
    /// <summary>
    ///     Time complexity - O(n log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int GetResult(int[] nums)
    {
        Array.Sort(nums);

        int i = 0;

        while (i < nums.Length && nums[i] == i)
        {
            i++;
        }

        return i;
    }
}