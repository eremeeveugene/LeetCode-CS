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

namespace LeetCode.Algorithms.NumberOfSubArraysWithOddSum;

/// <inheritdoc />
public sealed class NumberOfSubArraysWithOddSumPrefixSum : INumberOfSubArraysWithOddSum
{
    private const int Mod = (int)(1e9 + 7);

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int NumOfSubarrays(int[] arr)
    {
        var count = 0;
        var oddCount = 0;
        var evenCount = 1;
        var prefixSum = 0;

        foreach (var num in arr)
        {
            prefixSum += num;

            if (prefixSum % 2 == 0)
            {
                count += oddCount;

                evenCount++;
            }
            else
            {
                count += evenCount;

                oddCount++;
            }

            count %= Mod;
        }

        return count;
    }
}