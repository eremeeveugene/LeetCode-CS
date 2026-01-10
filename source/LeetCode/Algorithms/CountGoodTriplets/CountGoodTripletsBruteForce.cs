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
public sealed class CountGoodTripletsBruteForce : ICountGoodTriplets
{
    /// <summary>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        var result = 0;

        for (var i = 0; i < arr.Length - 2; i++)
        {
            for (var j = i + 1; j < arr.Length - 1; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) > a)
                {
                    continue;
                }

                for (var k = j + 1; k < arr.Length; k++)
                {
                    if (Math.Abs(arr[j] - arr[k]) <= b &&
                        Math.Abs(arr[i] - arr[k]) <= c)
                    {
                        result++;
                    }
                }
            }
        }

        return result;
    }
}