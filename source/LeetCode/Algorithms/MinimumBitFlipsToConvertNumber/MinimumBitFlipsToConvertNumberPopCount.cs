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

namespace LeetCode.Algorithms.MinimumBitFlipsToConvertNumber;

/// <inheritdoc />
public sealed class MinimumBitFlipsToConvertNumberPopCount : IMinimumBitFlipsToConvertNumber
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(b), where b is the number of bits in start and goal
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinBitFlips(int start, int goal)
    {
        return BitOperations.PopCount((uint)(start ^ goal));
    }
}