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

namespace LeetCode.Algorithms.SecondLargestDigitInString;

/// <inheritdoc />
public sealed class SecondLargestDigitInStringIterative : ISecondLargestDigitInString
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SecondHighest(string s)
    {
        var highest = -1;
        var secondHighest = -1;

        foreach (var c in s)
        {
            if (!char.IsDigit(c))
            {
                continue;
            }

            var num = c - '0';

            if (num > highest)
            {
                secondHighest = highest;
                highest = num;
            }
            else if (num > secondHighest && num < highest)
            {
                secondHighest = num;
            }
        }

        return secondHighest;
    }
}