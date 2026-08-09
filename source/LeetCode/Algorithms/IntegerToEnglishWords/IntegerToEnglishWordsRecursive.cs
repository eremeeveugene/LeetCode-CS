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

namespace LeetCode.Algorithms.IntegerToEnglishWords;

/// <inheritdoc />
public sealed class IntegerToEnglishWordsRecursive : IIntegerToEnglishWords
{
    private const string Space = " ";
    private const string Hundred = "Hundred";

    private static readonly string[] BelowTwenty =
    [
        "Zero",
        "One",
        "Two",
        "Three",
        "Four",
        "Five",
        "Six",
        "Seven",
        "Eight",
        "Nine",
        "Ten",
        "Eleven",
        "Twelve",
        "Thirteen",
        "Fourteen",
        "Fifteen",
        "Sixteen",
        "Seventeen",
        "Eighteen",
        "Nineteen"
    ];

    private static readonly string[] Tens = ["", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];

    private static readonly string[] Thousands = ["", "Thousand", "Million", "Billion"];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log 10 num)
    ///     Space complexity - O(log 10 num)
    /// </remarks>
    public string NumberToWords(int num)
    {
        if (num == 0)
        {
            return BelowTwenty[0];
        }

        var i = 0;

        var wordsStringBuilder = new StringBuilder();

        while (num > 0)
        {
            if (num % 1000 != 0)
            {
                wordsStringBuilder.Insert(0, ConvertBelowThousand(num % 1000) + Thousands[i] + Space);
            }

            num /= 1000;

            i++;
        }

        return wordsStringBuilder.ToString().Trim();
    }

    private static string ConvertBelowThousand(int num)
    {
        return num switch
        {
            0 => string.Empty,
            < 20 => BelowTwenty[num] + Space,
            < 100 => Tens[num / 10] + Space + ConvertBelowThousand(num % 10),
            _ => BelowTwenty[num / 100] + Space + Hundred + Space + ConvertBelowThousand(num % 100)
        };
    }
}