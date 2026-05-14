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

namespace LeetCode.Algorithms.CountIndicesWithOppositeParity;

/// <inheritdoc />
public sealed class CountIndicesWithOppositeParityCounting : ICountIndicesWithOppositeParity
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] CountOppositeParity(int[] nums)
    {
        var n = nums.Length;

        var oddCount = 0;
        var evenCount = 0;

        for (var i = n - 1; i >= 0; i--)
        {
            var num = nums[i];

            if (num % 2 == 0)
            {
                nums[i] = oddCount;

                evenCount++;
            }
            else
            {
                nums[i] = evenCount;

                oddCount++;
            }
        }

        return nums;
    }
}