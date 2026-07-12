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

namespace LeetCode.Algorithms.FindNumbersWithEvenNumberOfDigits;

/// <inheritdoc />
public sealed class FindNumbersWithEvenNumberOfDigitsGreedy : IFindNumbersWithEvenNumberOfDigits
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FindNumbers(int[] nums)
    {
        var count = 0;

        foreach (var num in nums)
        {
            if (num is >= 10 and < 100 or >= 1000 and < 10000 or >= 100000 and < 1000000 or >= 10000000 and < 100000000 or >= 1000000000)
            {
                count++;
            }
        }

        return count;
    }
}