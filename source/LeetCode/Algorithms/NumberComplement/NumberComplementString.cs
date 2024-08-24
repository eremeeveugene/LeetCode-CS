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

namespace LeetCode.Algorithms.NumberComplement;

/// <inheritdoc />
public class NumberComplementString : INumberComplement
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int FindComplement(int num)
    {
        var numBinaryString = Convert.ToString(num, 2);
        var stringBuilder = new StringBuilder(numBinaryString.Length);

        foreach (var bit in numBinaryString)
        {
            stringBuilder.Append(bit == '0' ? '1' : '0');
        }

        return Convert.ToInt32(stringBuilder.ToString(), 2);
    }
}