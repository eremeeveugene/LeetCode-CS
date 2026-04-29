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

namespace LeetCode.Algorithms.ValidDigitNumber;

/// <inheritdoc />
public sealed class ValidDigitNumberMath : IValidDigitNumber
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool ValidDigit(int n, int x)
    {
        var containsX = false;
        var firstDigit = 0;

        while (n > 0)
        {
            var digit = n % 10;

            if (digit == x)
            {
                containsX = true;
            }

            firstDigit = digit;

            n /= 10;
        }

        return containsX && firstDigit != x;
    }
}