// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.XORQueriesOfSubarray;

/// <inheritdoc />
public class XORQueriesOfSubarrayIterative : IXORQueriesOfSubarray
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="queries"></param>
    /// <returns></returns>
    public int[] XorQueries(int[] arr, int[][] queries)
    {
        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            for (var j = queries[i][0]; j <= queries[i][1]; j++)
            {
                result[i] ^= arr[j];
            }
        }

        return result;
    }
}