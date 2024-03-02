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
public class SquaresOfSortedArrayTwoPointers : ISquaresOfSortedArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SortedSquares(int[] nums)
    {
        var sortedSquares = new int[nums.Length];

        var left = 0;
        var right = nums.Length - 1;

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                sortedSquares[i] = (int)Math.Pow(nums[left], 2);
                left++;
            }
            else
            {
                sortedSquares[i] = (int)Math.Pow(nums[right], 2);
                right--;
            }
        }

        return sortedSquares;
    }
}