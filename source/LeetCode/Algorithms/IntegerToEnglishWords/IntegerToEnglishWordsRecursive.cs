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

namespace LeetCode.Algorithms.IntegerToEnglishWords;

/// <inheritdoc />
public class IntegerToEnglishWordsRecursive : IIntegerToEnglishWords
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

    private static readonly string[] Tens =
    [
        "",
        "",
        "Twenty",
        "Thirty",
        "Forty",
        "Fifty",
        "Sixty",
        "Seventy",
        "Eighty",
        "Ninety"
    ];

    private static readonly string[] Thousands = ["", "Thousand", "Million", "Billion"];

    /// <summary>
    ///     Time complexity - O(log 10 num)
    ///     Space complexity - O(log 10 num)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public string NumberToWords(int num)
    {
        if (num == 0)
        {
            return BelowTwenty[0];
        }

        var i = 0;
        var words = string.Empty;

        while (num > 0)
        {
            if (num % 1000 != 0)
            {
                words = Helper(num % 1000) + Thousands[i] + Space + words;
            }

            num /= 1000;

            i++;
        }

        return words.Trim();
    }

    private static string Helper(int num)
    {
        return num switch
        {
            0 => string.Empty,
            < 20 => BelowTwenty[num] + Space,
            < 100 => Tens[num / 10] + Space + Helper(num % 10),
            _ => BelowTwenty[num / 100] + Space + Hundred + Space + Helper(num % 100)
        };
    }
}