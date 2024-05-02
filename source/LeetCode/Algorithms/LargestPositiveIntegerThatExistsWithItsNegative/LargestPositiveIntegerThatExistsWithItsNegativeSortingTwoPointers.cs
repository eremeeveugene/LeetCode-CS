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

namespace LeetCode.Algorithms.LargestPositiveIntegerThatExistsWithItsNegative;

/// <inheritdoc />
public class LargestPositiveIntegerThatExistsWithItsNegativeSortingTwoPointers :
    ILargestPositiveIntegerThatExistsWithItsNegative
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindMaxK(int[] nums)
    {
        Array.Sort(nums);

        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var absLeft = Math.Abs(nums[left]);

            if (absLeft == nums[right])
            {
                return nums[right];
            }

            if (absLeft > nums[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return -1;
    }
}