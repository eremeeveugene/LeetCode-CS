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

using System.Globalization;

namespace LeetCode.Algorithms.HappyNumber;

/// <inheritdoc />
public sealed class HappyNumberHashSetChars : IHappyNumber
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool IsHappy(int n)
    {
        if (n == 1)
        {
            return true;
        }

        var hashSet = new HashSet<int>();

        while (n > 1 && !hashSet.Contains(n))
        {
            hashSet.Add(n);
            n = GetNext(n);
        }

        return n == 1;
    }

    private static int GetNext(int n)
    {
        var digits = n.ToString(CultureInfo.InvariantCulture);
        var sum = 0;

        for (var i = 0; i < digits.Length; i++)
        {
            var digit = digits[i] - '0';

            sum += digit * digit;
        }

        return sum;
    }
}