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

namespace LeetCode.Algorithms.MinimumMovesToEqualArrayElements3;

/// <inheritdoc />
public class MinimumMovesToEqualArrayElements3TwoPass : IMinimumMovesToEqualArrayElements3
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinMoves(int[] nums)
    {
        var max = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            max = Math.Max(max, num);
        }

        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            result += max - num;
        }

        return result;
    }
}