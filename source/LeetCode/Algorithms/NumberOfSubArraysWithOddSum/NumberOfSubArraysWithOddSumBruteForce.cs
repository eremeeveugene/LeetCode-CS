// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class NumberOfSubArraysWithOddSumBruteForce : INumberOfSubArraysWithOddSum
{
    private const int Mod = (int)(1e9 + 7);

    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int NumOfSubarrays(int[] arr)
    {
        var count = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            var currentSum = 0;

            for (var j = i; j < arr.Length; j++)
            {
                currentSum += arr[j];

                if (currentSum % 2 != 0)
                {
                    count++;
                }
            }
        }

        return count % Mod;
    }
}