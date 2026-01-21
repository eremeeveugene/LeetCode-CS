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

namespace LeetCode.Algorithms.ConstructTheMinimumBitwiseArray2;

/// <inheritdoc />
public sealed class ConstructTheMinimumBitwiseArray2BitManipulation : IConstructTheMinimumBitwiseArray2
{
    /// <summary>
    ///     Time complexity - O(n log m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] MinBitwiseArray(IList<int> nums)
    {
        var n = nums.Count;

        var result = new int[n];

        for (var i = 0; i < n; i++)
        {
            result[i] = FindMinValue(nums[i]);
        }

        return result;
    }

    private static int FindMinValue(int num)
    {
        if (num == 2)
        {
            return -1;
        }

        var t = 0;

        while (((num >> t) & 1) == 1)
        {
            t++;
        }

        return num - (1 << (t - 1));
    }
}