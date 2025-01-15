// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MinimizeXOR;

/// <inheritdoc />
public class MinimizeXORBitwise : IMinimizeXOR
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int MinimizeXor(int num1, int num2)
    {
        var result = 0;

        var num2SetBits = CountSetBits(num2);

        for (var i = 31; i >= 0 && num2SetBits > 0; i--)
        {
            if ((num1 & (1 << i)) == 0)
            {
                continue;
            }

            result |= 1 << i;

            num2SetBits--;
        }

        for (var i = 0; i < 32 && num2SetBits > 0; i++)
        {
            if ((result & (1 << i)) != 0)
            {
                continue;
            }

            result |= 1 << i;

            num2SetBits--;
        }

        return result;
    }

    private static int CountSetBits(int n)
    {
        var count = 0;

        while (n > 0)
        {
            count += n & 1;

            n >>= 1;
        }

        return count;
    }
}