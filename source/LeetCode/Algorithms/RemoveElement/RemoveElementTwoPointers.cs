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

namespace LeetCode.Algorithms.RemoveElement;

/// <inheritdoc />
public class RemoveElementTwoPointers : IRemoveElement
{
    /// <summary>
    ///     Time complexity - O (n)
    ///     Space complexity - O (1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public int RemoveElement(int[] nums, int val)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            if (nums[left] == val)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);

                right--;
            }
            else
            {
                left++;
            }
        }

        return left;
    }
}