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

namespace LeetCode.Algorithms.ComplementOfBase10Integer;

/// <inheritdoc />
public class ComplementOfBase10IntegerBitwise : IComplementOfBase10Integer
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int BitwiseComplement(int n)
    {
        var bitLengthLog = Math.Log(n, 2);

        var bitLength = (int)Math.Floor(bitLengthLog);

        var totalBits = bitLength + 1;

        var mask = (1 << totalBits) - 1;

        return n ^ mask;
    }
}