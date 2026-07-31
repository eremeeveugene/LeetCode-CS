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

namespace LeetCode.Algorithms.SmallestNumberWithAllSetBits;

/// <inheritdoc />
public sealed class SmallestNumberWithAllSetBitsBinarySearch : ISmallestNumberWithAllSetBits
{
    private static readonly int[] Numbers = [3, 7, 15, 31, 63, 127, 255, 511, 1023];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SmallestNumber(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        var index = Array.BinarySearch(Numbers, n);

        if (index >= 0)
        {
            return Numbers[index];
        }

        index = ~index;

        return Numbers[index];
    }
}