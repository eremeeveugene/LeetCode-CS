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

using System.Numerics;

namespace LeetCode.Algorithms.MinimumBitFlipsToConvertNumber;

/// <inheritdoc />
public class MinimumBitFlipsToConvertNumberPopCount : IMinimumBitFlipsToConvertNumber
{
    /// <summary>
    ///     Time complexity - O(b), where b is the number of bits in start and goal
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="goal"></param>
    /// <returns></returns>
    public int MinBitFlips(int start, int goal)
    {
        return BitOperations.PopCount((uint)(start ^ goal));
    }
}