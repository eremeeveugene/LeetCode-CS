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
public sealed class TransformArrayByParityTwoPointers : ITransformArrayByParity
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

        for (var right = 0; right < nums.Length; right++)
        {
            nums[right] = nums[right] % 2 == 0 ? 0 : 1;

            if (nums[right] != 0)
            {
                continue;
            }

            (nums[right], nums[left]) = (nums[left], nums[right]);

            left++;
        }

        return nums;
    }
}