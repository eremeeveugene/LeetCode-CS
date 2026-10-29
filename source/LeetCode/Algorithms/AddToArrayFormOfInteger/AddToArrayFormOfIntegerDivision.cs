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

namespace LeetCode.Algorithms.AddToArrayFormOfInteger;

/// <inheritdoc />
public sealed class AddToArrayFormOfIntegerDivision : IAddToArrayFormOfInteger
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(max(n, log k)), where n is the length of the array num and log k is the number of digits in the
    ///     integer k
    ///     Space complexity - O(max(n, log k)), where n is the length of the array num and log k is the number of digits in
    ///     the integer k
    /// </remarks>
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var result = new List<int>();

        var n = num.Length;

        var carry = k;

        for (var i = n - 1; i >= 0; i--)
        {
            var digit = num[i];
            var sum = digit + carry;

            result.Add(sum % 10);

            carry = sum / 10;
        }

        while (carry > 0)
        {
            result.Add(carry % 10);

            carry /= 10;
        }

        result.Reverse();

        return result;
    }
}