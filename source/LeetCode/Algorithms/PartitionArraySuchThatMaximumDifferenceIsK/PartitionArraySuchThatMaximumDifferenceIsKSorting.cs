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

namespace LeetCode.Algorithms.PartitionArraySuchThatMaximumDifferenceIsK;

/// <inheritdoc />
public class PartitionArraySuchThatMaximumDifferenceIsKSorting : IPartitionArraySuchThatMaximumDifferenceIsK
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int PartitionArray(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return 1;
        }

        Array.Sort(nums);

        var result = 0;

        var min = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] - min <= k)
            {
                continue;
            }

            result++;

            min = nums[i];
        }

        return result + 1;
    }
}