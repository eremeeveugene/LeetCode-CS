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

namespace LeetCode.Algorithms.DivideArrayIntoEqualPairs;

/// <inheritdoc />
public sealed class DivideArrayIntoEqualPairsArray : IDivideArrayIntoEqualPairs
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool DivideArray(int[] nums)
    {
        var frequencies = new int[501];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            frequencies[num]++;
        }

        for (var i = 0; i < frequencies.Length; i++)
        {
            if (frequencies[i] % 2 != 0)
            {
                return false;
            }
        }

        return true;
    }
}