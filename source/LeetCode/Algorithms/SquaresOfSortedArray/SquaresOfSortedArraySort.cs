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

namespace LeetCode.Algorithms.SquaresOfSortedArray;

/// <inheritdoc />
public class SquaresOfSortedArraySort : ISquaresOfSortedArray
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SortedSquares(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = (int)Math.Pow(nums[i], 2);
        }

        Array.Sort(nums);

        return nums;
    }
}