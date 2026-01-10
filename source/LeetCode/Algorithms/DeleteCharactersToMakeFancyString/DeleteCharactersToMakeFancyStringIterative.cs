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

namespace LeetCode.Algorithms.DeleteCharactersToMakeFancyString;

/// <inheritdoc />
public sealed class DeleteCharactersToMakeFancyStringIterative : IDeleteCharactersToMakeFancyString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string MakeFancyString(string s)
    {
        var resultStringBuilder = new StringBuilder();

        resultStringBuilder.Append(s[0]);

        var previous = s[0];
        var count = 1;

        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] == previous)
            {
                if (count == 2)
                {
                    continue;
                }

                resultStringBuilder.Append(s[i]);

                count++;
            }
            else
            {
                resultStringBuilder.Append(s[i]);

                previous = s[i];
                count = 1;
            }
        }

        return resultStringBuilder.ToString();
    }
}