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

namespace LeetCode.Algorithms.LargestThreeSameDigitNumberInString;

/// <inheritdoc />
public sealed class LargestThreeSameDigitNumberInStringGreedyOptimized : ILargestThreeSameDigitNumberInString
{
    private static readonly string[] Triples =
    [
        "000", "111", "222", "333", "444", "555", "666", "777", "888", "999"
    ];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public string LargestGoodInteger(string num)
    {
        var maxChar = '\0';

        for (var i = 0; i <= num.Length - 3; i++)
        {
            var c = num[i];

            if (c != num[i + 1] || c != num[i + 2] || c <= maxChar)
            {
                continue;
            }

            if (c == '9')
            {
                return Triples[^1];
            }

            maxChar = c;
        }

        return maxChar == '\0' ? string.Empty : Triples[maxChar - '0'];
    }
}