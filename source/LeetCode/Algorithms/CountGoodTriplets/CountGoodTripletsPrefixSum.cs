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

namespace LeetCode.Algorithms.CountGoodTriplets;

/// <inheritdoc />
public sealed class CountGoodTripletsPrefixSum : ICountGoodTriplets
{
    /// <summary>
    ///     Time complexity - O(n^2 + n * M)
    ///     Space complexity - O(M)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        var result = 0;
        var sum = new int[1001];

        for (var j = 0; j < arr.Length - 1; ++j)
        {
            for (var k = j + 1; k < arr.Length; ++k)
            {
                if (Math.Abs(arr[j] - arr[k]) > b)
                {
                    continue;
                }

                var left = Math.Max(0, Math.Max(arr[j] - a, arr[k] - c));
                var right = Math.Min(1000, Math.Min(arr[j] + a, arr[k] + c));

                if (left > right)
                {
                    continue;
                }

                if (left == 0)
                {
                    result += sum[right];
                }
                else
                {
                    result += sum[right] - sum[left - 1];
                }
            }

            for (var k = arr[j]; k <= 1000; ++k)
            {
                sum[k]++;
            }
        }

        return result;
    }
}