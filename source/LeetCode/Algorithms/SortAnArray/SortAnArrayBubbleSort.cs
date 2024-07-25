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

namespace LeetCode.Algorithms.SortAnArray;

/// <inheritdoc />
public class SortAnArrayBubbleSort : ISortAnArray
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SortArray(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                }
            }
        }

        return nums;
    }
}