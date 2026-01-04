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

namespace LeetCode.Algorithms.ZeroArrayTransformation1;

/// <inheritdoc />
public class ZeroArrayTransformation1PrefixSum : IZeroArrayTransformation1
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="queries"></param>
    /// <returns></returns>
    public bool IsZeroArray(int[] nums, int[][] queries)
    {
        var prefixSum = new int[nums.Length + 1];

        foreach (var query in queries)
        {
            prefixSum[query[0]]++;
            prefixSum[query[1] + 1]--;
        }

        var count = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            count += prefixSum[i];

            if (count < nums[i])
            {
                return false;
            }
        }

        return true;
    }
}