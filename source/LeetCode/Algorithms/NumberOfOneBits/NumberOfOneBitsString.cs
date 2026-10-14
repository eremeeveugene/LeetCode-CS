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

namespace LeetCode.Algorithms.NumberOfOneBits;

/// <inheritdoc />
public sealed class NumberOfOneBitsString : INumberOfOneBits
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int HammingWeight(int n)
    {
        var binaryString = Convert.ToString(n, 2);

        var count = 0;

        for (var i = 0; i < binaryString.Length; i++)
        {
            var bit = binaryString[i];

            if (bit == '1')
            {
                count++;
            }
        }

        return count;
    }
}