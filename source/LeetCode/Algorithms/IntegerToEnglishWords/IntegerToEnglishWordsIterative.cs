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
public sealed class IntegerToEnglishWordsIterative : IIntegerToEnglishWords
{
    private const char Space = ' ';

    private static readonly Dictionary<int, string> WordsDictionary = new()
    {
        { 1000000000, "Billion" },
        { 1000000, "Million" },
        { 1000, "Thousand" },
        { 100, "Hundred" },
        { 90, "Ninety" },
        { 80, "Eighty" },
        { 70, "Seventy" },
        { 60, "Sixty" },
        { 50, "Fifty" },
        { 40, "Forty" },
        { 30, "Thirty" },
        { 20, "Twenty" },
        { 19, "Nineteen" },
        { 18, "Eighteen" },
        { 17, "Seventeen" },
        { 16, "Sixteen" },
        { 15, "Fifteen" },
        { 14, "Fourteen" },
        { 13, "Thirteen" },
        { 12, "Twelve" },
        { 11, "Eleven" },
        { 10, "Ten" },
        { 9, "Nine" },
        { 8, "Eight" },
        { 7, "Seven" },
        { 6, "Six" },
        { 5, "Five" },
        { 4, "Four" },
        { 3, "Three" },
        { 2, "Two" },
        { 1, "One" },
        { 0, "Zero" }
    };

    private static readonly int[] DescendingWordKeys = [.. WordsDictionary.Keys.OrderDescending()];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log 10 num)
    ///     Space complexity - O(log 10 num)
    /// </remarks>
    public string NumberToWords(int num)
    {
        if (num == 0)
        {
            return WordsDictionary[0];
        }

        var resultStringBuilder = new StringBuilder();

        while (num > 0)
        {
            var wordKey = GetLargestWordKey(num);

            if (wordKey >= 100)
            {
                var count = num / wordKey;

                num -= count * wordKey;

                AppendBelowThousand(resultStringBuilder, count);
            }
            else
            {
                num -= wordKey;
            }

            resultStringBuilder.Append(WordsDictionary[wordKey]);
            resultStringBuilder.Append(Space);
        }

        return resultStringBuilder.ToString().TrimEnd();
    }

    private static int GetLargestWordKey(int num)
    {
        for (var i = 0; i < DescendingWordKeys.Length; i++)
        {
            var key = DescendingWordKeys[i];

            if (key <= num)
            {
                return key;
            }
        }

        return 0;
    }

    private static void AppendBelowThousand(StringBuilder resultStringBuilder, int count)
    {
        if (count >= 100)
        {
            var hundredsCount = count / 100;

            count -= hundredsCount * 100;

            resultStringBuilder.Append(WordsDictionary[hundredsCount]);
            resultStringBuilder.Append(Space);
            resultStringBuilder.Append(WordsDictionary[100]);
            resultStringBuilder.Append(Space);
        }

        if (count >= 20)
        {
            var tensCount = count / 10;

            count -= tensCount * 10;

            resultStringBuilder.Append(WordsDictionary[tensCount * 10]);
            resultStringBuilder.Append(Space);
        }

        if (count >= 10)
        {
            resultStringBuilder.Append(WordsDictionary[count]);
            resultStringBuilder.Append(Space);

            count = 0;
        }

        if (count == 0)
        {
            return;
        }

        resultStringBuilder.Append(WordsDictionary[count]);
        resultStringBuilder.Append(Space);
    }
}