// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using System.Text;

namespace LeetCode.Algorithms.MaximumOddBinaryNumber;

/// <inheritdoc />
public class MaximumOddBinaryNumberStringBuilder : IMaximumOddBinaryNumber
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string MaximumOddBinaryNumber(string s)
    {
        var onesCount = s.Count(c => c == '1');

        var stringBuilder = new StringBuilder();

        for (var i = 0; i < onesCount - 1; i++)
        {
            stringBuilder.Append('1');
        }

        for (var i = 0; i < s.Length - onesCount; i++)
        {
            stringBuilder.Append('0');
        }

        stringBuilder.Append('1');

        return stringBuilder.ToString();
    }
}