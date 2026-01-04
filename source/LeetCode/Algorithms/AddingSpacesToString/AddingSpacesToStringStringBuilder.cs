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

namespace LeetCode.Algorithms.AddingSpacesToString;

/// <inheritdoc />
public class AddingSpacesToStringStringBuilder : IAddingSpacesToString
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="spaces"></param>
    /// <returns></returns>
    public string AddSpaces(string s, int[] spaces)
    {
        var stringBuilder = new StringBuilder();

        var spaceIndex = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (spaceIndex < spaces.Length && i == spaces[spaceIndex])
            {
                stringBuilder.Append(' ');

                spaceIndex++;
            }

            stringBuilder.Append(s[i]);
        }

        return stringBuilder.ToString();
    }
}