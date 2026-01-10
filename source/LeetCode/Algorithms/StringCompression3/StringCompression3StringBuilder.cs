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

namespace LeetCode.Algorithms.StringCompression3;

/// <inheritdoc />
public sealed class StringCompression3StringBuilder : IStringCompression3
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public string CompressedString(string word)
    {
        var stringBuilder = new StringBuilder();

        var currentCharacter = '0';
        var count = 0;

        foreach (var character in word)
        {
            if (currentCharacter == character && count < 9)
            {
                count++;
            }
            else
            {
                if (count > 0)
                {
                    stringBuilder.Append($"{count}{currentCharacter}");
                }

                count = 1;
                currentCharacter = character;
            }
        }

        stringBuilder.Append($"{count}{currentCharacter}");

        return stringBuilder.ToString();
    }
}