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

namespace LeetCode.Algorithms.LargestIntegerWithGivenDigitSum;

/// <inheritdoc />
public sealed class LargestIntegerWithGivenDigitSumGreedy : ILargestIntegerWithGivenDigitSum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int LargestInteger(int n, int s)
    {
        if (s > n * 9)
        {
            return -1;
        }

        var largestNumber = 0;

        var remainingSum = s;

        for (var i = 0; i < n; i++)
        {
            var digit = Math.Min(remainingSum, 9);

            largestNumber = (largestNumber * 10) + digit;

            remainingSum -= digit;
        }

        return largestNumber;
    }
}