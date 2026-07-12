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

using System.Text;

namespace LeetCode.Algorithms.ZigzagConversion;

/// <inheritdoc />
public sealed class ZigzagConversionSimulation : IZigzagConversion
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || s.Length <= numRows)
        {
            return s;
        }

        var stringBuilders = new StringBuilder[numRows];

        for (var i = 0; i < stringBuilders.Length; i++)
        {
            stringBuilders[i] = new StringBuilder();
        }

        var index = 0;

        var goingDown = false;

        foreach (var c in s)
        {
            stringBuilders[index].Append(c);

            if (index == 0 || index == numRows - 1)
            {
                goingDown = !goingDown;
            }

            index += goingDown ? 1 : -1;
        }

        var resultStringBuilder = new StringBuilder();

        foreach (var stringBuilder in stringBuilders)
        {
            resultStringBuilder.Append(stringBuilder);
        }

        return resultStringBuilder.ToString();
    }
}