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

namespace LeetCode.Algorithms.MaximumWidthRamp;

/// <inheritdoc />
public class MaximumWidthRampStack : IMaximumWidthRamp
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxWidthRamp(int[] nums)
    {
        var stack = new Stack<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (stack.Count == 0 || nums[i] < nums[stack.Peek()])
            {
                stack.Push(i);
            }
        }

        var ramp = 0;

        for (var j = nums.Length - 1; j >= 0; j--)
        {
            while (stack.Count > 0 && nums[j] >= nums[stack.Peek()])
            {
                ramp = Math.Max(ramp, j - stack.Pop());
            }
        }

        return ramp;
    }
}