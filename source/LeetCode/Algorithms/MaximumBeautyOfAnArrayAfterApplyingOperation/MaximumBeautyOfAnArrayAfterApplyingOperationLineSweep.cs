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

namespace LeetCode.Algorithms.MaximumBeautyOfAnArrayAfterApplyingOperation;

/// <inheritdoc />
public sealed class MaximumBeautyOfAnArrayAfterApplyingOperationLineSweep : IMaximumBeautyOfAnArrayAfterApplyingOperation
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MaximumBeauty(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return 1;
        }

        var ranges = new (int Position, int Type)[nums.Length * 2];

        for (var i = 0; i < nums.Length; i++)
        {
            ranges[i] = (nums[i] - k, 1);
            ranges[i + nums.Length] = (nums[i] + k, -1);
        }

        Array.Sort(ranges,
            (x, y) => x.Position == y.Position ? y.Type.CompareTo(x.Type) : x.Position.CompareTo(y.Position));

        var maximumBeauty = 0;
        var count = 0;

        for (var i = 0; i < ranges.Length; i++)
        {
            count += ranges[i].Type;

            maximumBeauty = Math.Max(maximumBeauty, count);
        }

        return maximumBeauty;
    }
}