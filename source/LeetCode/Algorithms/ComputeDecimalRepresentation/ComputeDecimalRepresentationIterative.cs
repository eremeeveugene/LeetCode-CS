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

namespace LeetCode.Algorithms.ComputeDecimalRepresentation;

/// <inheritdoc />
public sealed class ComputeDecimalRepresentationIterative : IComputeDecimalRepresentation
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] DecimalRepresentation(int n)
    {
        Span<int> buffer = stackalloc int[10];

        var length = 0;
        var power = 1;

        while (n > 0)
        {
            var digit = n % 10;

            if (digit != 0)
            {
                buffer[length] = digit * power;

                length++;
            }

            n /= 10;
            power *= 10;
        }

        var result = new int[length];

        for (var i = 0; i < length; i++)
        {
            result[i] = buffer[length - i - 1];
        }

        return result;
    }
}