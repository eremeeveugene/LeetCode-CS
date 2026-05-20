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

namespace LeetCode.Algorithms.FindThePrefixCommonArrayOfTwoArrays;

/// <inheritdoc />
public sealed class FindThePrefixCommonArrayOfTwoArraysFrequencyArraySpan : IFindThePrefixCommonArrayOfTwoArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] FindThePrefixCommonArray(int[] a, int[] b)
    {
        var n = a.Length;

        var result = new int[n];

        Span<byte> frequencyArray = stackalloc byte[n + 1];

        var count = 0;

        for (var i = 0; i < n; i++)
        {
            var aItem = a[i];

            frequencyArray[aItem]++;

            if (frequencyArray[aItem] == 2)
            {
                count++;
            }

            var bItem = b[i];

            frequencyArray[bItem]++;

            if (frequencyArray[bItem] == 2)
            {
                count++;
            }

            result[i] = count;
        }

        return result;
    }
}