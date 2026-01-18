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
public sealed class RotateArrayBruteForce : IRotateArray
{
    /// <summary>
    ///     Time complexity - O(n * k)
    ///     Space complexity - O(1)
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

        for (var i = 0; i < k; i++)
        {
            var last = nums[n - 1];

            for (var j = n - 1; j > 0; j--)
            {
                nums[j] = nums[j - 1];
            }

            nums[0] = last;
        }
    }
}