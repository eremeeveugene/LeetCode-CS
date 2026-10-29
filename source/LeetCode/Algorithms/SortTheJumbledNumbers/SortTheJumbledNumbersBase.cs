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

namespace LeetCode.Algorithms.SortTheJumbledNumbers;

/// <inheritdoc />
public abstract class SortTheJumbledNumbersBase : ISortTheJumbledNumbers
{
    /// <inheritdoc />
    public abstract int[] SortJumbled(int[] mapping, int[] nums);

    /// <summary>
    ///     Computes the mapped value of <paramref name="num" /> by replacing each of its digits <c>d</c> with
    ///     <c>mapping[d]</c>.
    /// </summary>
    /// <param name="mapping">The digit mapping, where <c>mapping[d]</c> replaces the digit <c>d</c>.</param>
    /// <param name="num">The non-negative integer to map.</param>
    /// <returns>The mapped value of <paramref name="num" />.</returns>
    /// <remarks>
    ///     Time complexity - O(log num)
    ///     Space complexity - O(1)
    /// </remarks>
    protected static int GetMappedNum(int[] mapping, int num)
    {
        var mappedNum = 0;
        var multiplier = 1;

        do
        {
            var digit = num % 10;

            mappedNum += mapping[digit] * multiplier;
            num /= 10;
            multiplier *= 10;
        } while (num > 0);

        return mappedNum;
    }
}