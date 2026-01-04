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

namespace LeetCode.Algorithms.FindTheKthCharacterInStringGame1;

/// <inheritdoc />
public class FindTheKthCharacterInStringGame1StringBuilder : IFindTheKthCharacterInStringGame1
{
    /// <summary>
    ///     Time complexity - O(k)
    ///     Space complexity - O(k)
    /// </summary>
    /// <param name="k"></param>
    /// <returns></returns>
    public char KthCharacter(int k)
    {
        var stringBuilder = new StringBuilder("a");

        while (stringBuilder.Length < k)
        {
            var length = stringBuilder.Length;

            for (var i = 0; i < length; i++)
            {
                var nextChar = NextChar(stringBuilder[i]);

                stringBuilder.Append(nextChar);
            }
        }

        return stringBuilder[k - 1];
    }

    private static char NextChar(char c)
    {
        return c == 'z' ? 'a' : (char)(c + 1);
    }
}