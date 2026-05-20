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

using System.Numerics;

namespace LeetCode.Algorithms.FindThePrefixCommonArrayOfTwoArrays;

/// <inheritdoc />
public sealed class FindThePrefixCommonArrayOfTwoArraysBitmask : IFindThePrefixCommonArrayOfTwoArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] FindThePrefixCommonArray(int[] a, int[] b)
    {
        var n = a.Length;

        var result = new int[n];

        long maskA = 0;
        long maskB = 0;

        for (var i = 0; i < n; i++)
        {
            maskA |= 1L << a[i];
            maskB |= 1L << b[i];

            result[i] = BitOperations.PopCount((ulong)(maskA & maskB));
        }

        return result;
    }
}