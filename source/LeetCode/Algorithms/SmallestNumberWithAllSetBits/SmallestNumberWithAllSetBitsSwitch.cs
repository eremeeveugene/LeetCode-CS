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
public sealed class SmallestNumberWithAllSetBitsSwitch : ISmallestNumberWithAllSetBits
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int SmallestNumber(int n)
    {
        return n switch
        {
            1 => 1,
            <= 3 => 3,
            <= 7 => 7,
            <= 15 => 15,
            <= 31 => 31,
            <= 63 => 63,
            <= 127 => 127,
            <= 255 => 255,
            <= 511 => 511,
            _ => 1023
        };
    }
}