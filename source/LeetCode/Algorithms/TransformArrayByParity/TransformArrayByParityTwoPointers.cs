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

namespace LeetCode.Algorithms.TransformArrayByParity;

/// <inheritdoc />
public class TransformArrayByParityTwoPointers : ITransformArrayByParity
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] TransformArray(int[] nums)
    {
        var left = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] % 2 == 0 ? 0 : 1;

            if (nums[i] != 0)
            {
                continue;
            }

            (nums[i], nums[left]) = (nums[left], nums[i]);

            left++;
        }

        return nums;
    }
}