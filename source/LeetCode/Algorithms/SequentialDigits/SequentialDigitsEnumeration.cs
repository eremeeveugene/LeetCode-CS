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

namespace LeetCode.Algorithms.SequentialDigits;

/// <inheritdoc />
public sealed class SequentialDigitsEnumeration : ISequentialDigits
{
    private static readonly List<int> Numbers = BuildNumbers();

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1), since there are only 36 sequential-digit numbers to scan
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<int> SequentialDigits(int low, int high)
    {
        var result = new List<int>();

        var n = Numbers.Count;

        for (var i = 0; i < n; i++)
        {
            var number = Numbers[i];

            if (number > high)
            {
                break;
            }

            if (number >= low)
            {
                result.Add(number);
            }
        }

        return result;
    }

    /// <summary>
    ///     Builds all 36 sequential-digit numbers in ascending order, from 12 to 123456789.
    /// </summary>
    /// <returns>The sorted list of all sequential-digit numbers.</returns>
    /// <remarks>
    ///     Time complexity - O(1), since the digit lengths and start digits are fixed
    ///     Space complexity - O(1)
    /// </remarks>
    private static List<int> BuildNumbers()
    {
        var numbers = new List<int>();

        for (var length = 2; length <= 9; length++)
        {
            for (var start = 1; start + length - 1 <= 9; start++)
            {
                var number = 0;

                for (var digit = start; digit < start + length; digit++)
                {
                    number = (number * 10) + digit;
                }

                numbers.Add(number);
            }
        }

        return numbers;
    }
}