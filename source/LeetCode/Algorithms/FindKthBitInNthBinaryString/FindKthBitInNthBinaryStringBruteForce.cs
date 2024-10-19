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

namespace LeetCode.Algorithms.FindKthBitInNthBinaryString;

/// <inheritdoc />
public class FindKthBitInNthBinaryStringBruteForce : IFindKthBitInNthBinaryString
{
    /// <summary>
    ///     Time complexity - O(2^n)
    ///     Space complexity - O(2^n)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public char FindKthBit(int n, int k)
    {
        var s = "0";

        for (var i = 0; i < n - 1; i++)
        {
            s = ModifyString(s);
        }

        return s[k - 1];
    }

    private static string ModifyString(string s)
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.Append(s);
        stringBuilder.Append('1');

        for (var i = s.Length - 1; i >= 0; i--)
        {
            stringBuilder.Append(s[i] == '0' ? '1' : '0');
        }

        return stringBuilder.ToString();
    }
}