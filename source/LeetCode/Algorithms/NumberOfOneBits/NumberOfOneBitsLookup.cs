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

namespace LeetCode.Algorithms.NumberOfOneBits;

/// <inheritdoc />
public class NumberOfOneBitsLookup : INumberOfOneBits
{
    private static readonly int[] WordBits = new int[65536];

    static NumberOfOneBitsLookup()
    {
        uint i;

        for (i = 0; i <= 0xFFFF; i++)
        {
            var x = i;

            int count;

            for (count = 0; x > 0; count++)
            {
                x &= x - 1;
            }

            WordBits[i] = count;
        }
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int HammingWeight(int n)
    {
        return WordBits[n & 0xFFFF] + WordBits[(n >> 16) & 0xFFFF];
    }
}