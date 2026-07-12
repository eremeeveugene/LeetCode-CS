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

namespace LeetCode.Algorithms.ReverseBits;

/// <inheritdoc />
public sealed class ReverseBitsDivideAndConquer : IReverseBits
{
    private const int Mask1 = 0x55555555;
    private const int Mask2 = 0x33333333;
    private const int Mask4 = 0x0F0F0F0F;
    private const int Mask8 = 0x00FF00FF;
    private const int Mask16 = 0x0000FFFF;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int ReverseBits(int n)
    {
        n = ((n >> 1) & Mask1) | ((n & Mask1) << 1);
        n = ((n >> 2) & Mask2) | ((n & Mask2) << 2);
        n = ((n >> 4) & Mask4) | ((n & Mask4) << 4);
        n = ((n >> 8) & Mask8) | ((n & Mask8) << 8);
        n = ((n >> 16) & Mask16) | ((n & Mask16) << 16);

        return n;
    }
}