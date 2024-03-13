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

namespace LeetCode.Algorithms.ArrayPartition;

/// <inheritdoc />
public class ArrayPartitionSorting : IArrayPartition
{
    /// <summary>
    ///     Time complexity - O (n log n)
    ///     Space complexity - O (log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int ArrayPairSum(int[] nums)
    {
        Array.Sort(nums);

        var sum = 0;

        for (var i = 0; i < nums.Length; i += 2)
        {
            sum += Math.Min(nums[i], nums[i + 1]);
        }

        return sum;
    }
}