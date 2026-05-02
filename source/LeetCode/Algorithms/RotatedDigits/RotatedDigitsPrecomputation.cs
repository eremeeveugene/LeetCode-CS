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

using System.Collections;

namespace LeetCode.Algorithms.RotatedDigits;

/// <inheritdoc />
public sealed class RotatedDigitsPrecomputation : IRotatedDigits
{
    private const int MaxLength = 10_001;
    private static readonly BitArray GoodNumbers = new(MaxLength);

    /// <summary>
    ///     Precomputes all good numbers up to the maximum constraint using digit rotation rules.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    static RotatedDigitsPrecomputation()
    {
        for (var i = 1; i < MaxLength; i++)
        {
            if (IsGoodNumber(i))
            {
                GoodNumbers[i] = true;
            }
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int RotatedDigits(int n)
    {
        var result = 0;

        for (var i = 1; i <= n; i++)
        {
            if (GoodNumbers[i])
            {
                result++;
            }
        }

        return result;
    }

    /// <summary>
    ///     Determines whether the number remains valid and changes after rotating each digit by 180 degrees.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsGoodNumber(int number)
    {
        var isChanged = false;

        while (number > 0)
        {
            var digit = number % 10;

            switch (digit)
            {
                case 3 or 4 or 7:
                    return false;
                case 2 or 5 or 6 or 9:
                    isChanged = true;
                    break;
            }

            number /= 10;
        }

        return isChanged;
    }
}