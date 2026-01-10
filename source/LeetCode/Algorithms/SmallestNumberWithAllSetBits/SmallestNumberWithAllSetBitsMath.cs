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
public sealed class SmallestNumberWithAllSetBitsMath : ISmallestNumberWithAllSetBits
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int SmallestNumber(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        var k = (int)Math.Ceiling(Math.Log2(n + 1));

        return (1 << k) - 1;
    }
}