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

namespace LeetCode.Algorithms.RotateArray;

/// <inheritdoc />
public sealed class RotateArrayWithBuffer : IRotateArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    public void Rotate(int[] nums, int k)
    {
        var n = nums.Length;

        k %= n;

        if (k == 0)
        {
            return;
        }

        Span<int> rotated = stackalloc int[n];

        for (var i = 0; i < n; i++)
        {
            var index = (i + k) % n;

            rotated[index] = nums[i];
        }

        rotated.CopyTo(nums);
    }
}