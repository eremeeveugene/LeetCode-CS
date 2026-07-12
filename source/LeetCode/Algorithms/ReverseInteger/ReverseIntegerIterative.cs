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

namespace LeetCode.Algorithms.ReverseInteger;

/// <inheritdoc />
public sealed class ReverseIntegerIterative : IReverseInteger
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log(n))
    ///     Space complexity - O(1)
    /// </remarks>
    public int Reverse(int x)
    {
        long result = 0;

        while (x != 0)
        {
            result *= 10;
            result += x % 10;

            if (result is > int.MaxValue or < int.MinValue)
            {
                return 0;
            }

            x /= 10;
        }

        return (int)result;
    }
}