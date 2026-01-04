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

namespace LeetCode.Algorithms.MinimumOperationsToMakeArrayValuesEqualToK;

/// <inheritdoc />
public class MinimumOperationsToMakeArrayValuesEqualToKSeenArray : IMinimumOperationsToMakeArrayValuesEqualToK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MinOperations(int[] nums, int k)
    {
        var minOperations = 0;

        var seenNums = new bool[100];

        foreach (var num in nums)
        {
            if (num < k)
            {
                return -1;
            }

            if (num <= k || seenNums[num - 1])
            {
                continue;
            }

            seenNums[num - 1] = true;

            minOperations++;
        }

        return minOperations;
    }
}