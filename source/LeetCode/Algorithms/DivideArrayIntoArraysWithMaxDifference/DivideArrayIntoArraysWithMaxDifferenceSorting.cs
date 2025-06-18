// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.DivideArrayIntoArraysWithMaxDifference;

/// <inheritdoc />
public class DivideArrayIntoArraysWithMaxDifferenceSorting : IDivideArrayIntoArraysWithMaxDifference
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Time complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int[][] DivideArray(int[] nums, int k)
    {
        Array.Sort(nums);

        var result = new int[nums.Length / 3][];

        for (var i = 0; i < nums.Length; i += 3)
        {
            if (nums[i + 1] - nums[i] > k || nums[i + 2] - nums[i] > k)
            {
                return [];
            }

            result[i / 3] = [nums[i], nums[i + 1], nums[i + 2]];
        }

        return result;
    }
}