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

namespace LeetCode.Algorithms.MaximumOddBinaryNumber;

/// <inheritdoc />
public sealed class MaximumOddBinaryNumberStrings : IMaximumOddBinaryNumber
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string MaximumOddBinaryNumber(string s)
    {
        var onesCount = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                onesCount++;
            }
        }

        return new string('1', onesCount - 1) + new string('0', s.Length - onesCount) + '1';
    }
}