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

namespace LeetCode.Algorithms.IntegerToEnglishWords;

/// <inheritdoc />
public class IntegerToEnglishWordsIterative : IIntegerToEnglishWords
{
    private const string Space = " ";

    private readonly Dictionary<int, string> _wordsDictionary = new()
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
            return _wordsDictionary[0];
        }

        var resultStringBuilder = new StringBuilder();

        while (num > 0)
        {
            foreach (var word in _wordsDictionary.Where(word => num - word.Key >= 0))
            {
                if (word.Key >= 100)
                {
                    var count = num / word.Key;

                    num -= count * word.Key;

                    if (count >= 100)
                    {
                        var hundredsCount = count / 100;

                        count -= hundredsCount * 100;

                        resultStringBuilder.Append(_wordsDictionary[hundredsCount]);
                        resultStringBuilder.Append(Space);
                        resultStringBuilder.Append(_wordsDictionary[100]);
                        resultStringBuilder.Append(Space);
                    }

                    if (count >= 20)
                    {
                        var tensCount = count / 10;

                        count -= tensCount * 10;

                        resultStringBuilder.Append(_wordsDictionary[tensCount * 10]);
                        resultStringBuilder.Append(Space);
                    }

                    if (count >= 10)
                    {
                        resultStringBuilder.Append(_wordsDictionary[count]);
                        resultStringBuilder.Append(Space);

                        count = 0;
                    }

                    if (count >= 1)
                    {
                        resultStringBuilder.Append(_wordsDictionary[count]);
                        resultStringBuilder.Append(Space);
                    }
                }
                else
                {
                    num -= word.Key;
                }

                resultStringBuilder.Append(word.Value);
                resultStringBuilder.Append(Space);

                break;
            }
        }

        return resultStringBuilder.ToString().TrimEnd();
    }
}