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

namespace LeetCode.Algorithms.PowerOfTwo;

/// <inheritdoc />
public sealed class PowerOfTwoBinaryString : IPowerOfTwo
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public bool IsPowerOfTwo(int n)
    {
        if (n <= 0)
        {
            return false;
        }

        var binary = Convert.ToString(n, 2);
        var onesCount = 0;

        for (var i = 0; i < binary.Length; i++)
        {
            var bit = binary[i];

            if (bit == '1')
            {
                onesCount++;
            }
        }

        return onesCount == 1;
    }
}