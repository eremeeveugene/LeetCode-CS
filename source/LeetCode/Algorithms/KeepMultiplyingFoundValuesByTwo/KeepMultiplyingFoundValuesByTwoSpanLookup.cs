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

namespace LeetCode.Algorithms.KeepMultiplyingFoundValuesByTwo;

/// <inheritdoc />
public class KeepMultiplyingFoundValuesByTwoSpanLookup : KeepMultiplyingFoundValuesByTwoBase
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="original"></param>
    /// <returns></returns>
    public override int FindFinalValue(int[] nums, int original)
    {
        Span<bool> numsLookup = stackalloc bool[MaxNum + 1];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            numsLookup[num] = true;
        }

        while (original <= MaxNum && numsLookup[original])
        {
            original *= 2;
        }

        return original;
    }
}