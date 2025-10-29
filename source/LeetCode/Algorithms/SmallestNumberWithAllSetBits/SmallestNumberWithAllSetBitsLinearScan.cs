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

namespace LeetCode.Algorithms.SmallestNumberWithAllSetBits;

/// <inheritdoc />
public class SmallestNumberWithAllSetBitsLinearScan : ISmallestNumberWithAllSetBits
{
    private static readonly int[] Numbers =
    [
        3,
        7,
        15,
        31,
        63,
        127,
        255,
        511,
        1023
    ];

    /// <summary>
    ///     Time complexity - O(n)
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

        for (var i = 0; i < Numbers.Length - 1; i++)
        {
            var number = Numbers[i];

            if (number < n)
            {
                continue;
            }

            return number;
        }

        return Numbers[^1];
    }
}