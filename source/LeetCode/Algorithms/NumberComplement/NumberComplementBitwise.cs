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

namespace LeetCode.Algorithms.NumberComplement;

/// <inheritdoc />
public sealed class NumberComplementBitwise : INumberComplement
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FindComplement(int num)
    {
        var bitLengthLog = Math.Log(num, 2);

        var bitLength = (int)Math.Floor(bitLengthLog);

        var totalBits = bitLength + 1;

        var mask = (1 << totalBits) - 1;

        return num ^ mask;
    }
}