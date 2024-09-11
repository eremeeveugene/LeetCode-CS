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

namespace LeetCode.Algorithms.MinimumBitFlipsToConvertNumber;

/// <inheritdoc />
public class MinimumBitFlipsToConvertNumberBitwise : IMinimumBitFlipsToConvertNumber
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
        var xor = start ^ goal;

        var count = 0;

        while (xor > 0)
        {
            count += xor & 1;

            xor >>= 1;
        }

        return count;
    }
}