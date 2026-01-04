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

namespace LeetCode.Algorithms.TransformArrayByParity;

/// <inheritdoc />
public class TransformArrayByParityTwoPass : ITransformArrayByParity
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] TransformArray(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                nums[i] = 0;
            }
            else
            {
                nums[i] = 1;
            }
        }

        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            if (nums[left] == 0)
            {
                left++;
            }
            else if (nums[right] == 1)
            {
                right--;
            }
            else
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);

                left++;
                right--;
            }
        }

        return nums;
    }
}