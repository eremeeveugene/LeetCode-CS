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

namespace LeetCode.Algorithms.MakeArrayElementsEqualToZero;

/// <inheritdoc />
public sealed class MakeArrayElementsEqualToZeroPrefixSum : IMakeArrayElementsEqualToZero
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int CountValidSelections(int[] nums)
    {
        var result = 0;

        var left = 0;
        var right = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            right += num;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num == 0)
            {
                if (left - right is 0 or 1)
                {
                    result++;
                }

                if (right - left is 0 or 1)
                {
                    result++;
                }
            }
            else
            {
                left += num;
                right -= num;
            }
        }

        return result;
    }
}