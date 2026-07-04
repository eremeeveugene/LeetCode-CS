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

namespace LeetCode.Algorithms.SmallestIntegerDivisibleByK;

/// <inheritdoc />
public sealed class SmallestIntegerDivisibleByKIterative : ISmallestIntegerDivisibleByK
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(k)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SmallestRepunitDivByK(int k)
    {
        if (k % 2 == 0 || k % 5 == 0)
        {
            return -1;
        }

        var remainder = 0;

        for (var length = 1; length <= k; length++)
        {
            remainder = ((remainder * 10) + 1) % k;

            if (remainder == 0)
            {
                return length;
            }
        }

        return -1;
    }
}