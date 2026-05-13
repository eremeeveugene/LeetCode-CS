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

namespace LeetCode.Algorithms.ConcatenateArrayWithReverse;

/// <inheritdoc />
public sealed class ConcatenateArrayWithReverseOnePass : IConcatenateArrayWithReverse
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] ConcatWithReverse(int[] nums)
    {
        var n = nums.Length;

        var result = new int[n * 2];

        for (var i = 0; i < n; i++)
        {
            result[i] = nums[i];
            result[n + i] = nums[n - i - 1];
        }

        return result;
    }
}