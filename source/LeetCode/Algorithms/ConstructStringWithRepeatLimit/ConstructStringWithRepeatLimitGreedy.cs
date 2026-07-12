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

namespace LeetCode.Algorithms.ConstructStringWithRepeatLimit;

/// <inheritdoc />
public sealed class ConstructStringWithRepeatLimitGreedy : IConstructStringWithRepeatLimit
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string RepeatLimitedString(string s, int repeatLimit)
    {
        var countArray = new int['z' - 'a' + 1];

        foreach (var c in s)
        {
            countArray[c - 'a']++;
        }

        var resultStringBuilder = new StringBuilder();

        var character = 'z' - 'a';

        while (character >= 0)
        {
            if (countArray[character] == 0)
            {
                character--;

                continue;
            }

            var count = Math.Min(countArray[character], repeatLimit);

            countArray[character] -= count;

            for (var i = 0; i < count; i++)
            {
                resultStringBuilder.Append((char)('a' + character));
            }

            if (count < repeatLimit || countArray[character] == 0)
            {
                continue;
            }

            var nextCharacter = character - 1;

            while (nextCharacter >= 0 && countArray[nextCharacter] == 0)
            {
                nextCharacter--;
            }

            if (nextCharacter < 0)
            {
                break;
            }

            resultStringBuilder.Append((char)('a' + nextCharacter));

            countArray[nextCharacter]--;
        }

        return resultStringBuilder.ToString();
    }
}