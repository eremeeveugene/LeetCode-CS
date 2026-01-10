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

namespace LeetCode.Algorithms.GoatLatin;

/// <inheritdoc />
public sealed class GoatLatinSimulation : IGoatLatin
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="sentence"></param>
    /// <returns></returns>
    public string ToGoatLatin(string sentence)
    {
        var resultStringBuilder = new StringBuilder(sentence.Length * 2);
        var isFirstLetter = true;
        var firstLetter = '\0';
        var wordIndex = 0;

        foreach (var character in sentence)
        {
            if (isFirstLetter)
            {
                firstLetter = character;

                isFirstLetter = false;

                if (IsVowel(firstLetter))
                {
                    resultStringBuilder.Append(firstLetter);
                }
            }
            else if (character == ' ')
            {
                CloseWord(resultStringBuilder, firstLetter, ref wordIndex);

                resultStringBuilder.Append(' ');

                isFirstLetter = true;
            }
            else
            {
                resultStringBuilder.Append(character);
            }
        }

        CloseWord(resultStringBuilder, firstLetter, ref wordIndex);

        return resultStringBuilder.ToString();
    }

    private static bool IsVowel(char c)
    {
        return char.ToLowerInvariant(c) is 'a' or 'e' or 'i' or 'o' or 'u';
    }

    private static void CloseWord(StringBuilder stringBuilder, char firstLetter, ref int wordIndex)
    {
        if (!IsVowel(firstLetter))
        {
            stringBuilder.Append(firstLetter);
        }

        stringBuilder.Append("ma");

        wordIndex++;

        stringBuilder.Append('a', wordIndex);
    }
}