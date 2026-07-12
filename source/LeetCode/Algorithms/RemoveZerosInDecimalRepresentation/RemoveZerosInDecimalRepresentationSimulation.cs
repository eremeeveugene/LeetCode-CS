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

namespace LeetCode.Algorithms.RemoveZerosInDecimalRepresentation;

/// <inheritdoc />
public sealed class RemoveZerosInDecimalRepresentationSimulation : IRemoveZerosInDecimalRepresentation
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public long RemoveZeros(long n)
    {
        long result = 0;
        long multiply = 1;

        while (n > 0)
        {
            var digit = n % 10;

            if (digit != 0)
            {
                result += digit * multiply;

                multiply *= 10;
            }

            n /= 10;
        }

        return result;
    }
}