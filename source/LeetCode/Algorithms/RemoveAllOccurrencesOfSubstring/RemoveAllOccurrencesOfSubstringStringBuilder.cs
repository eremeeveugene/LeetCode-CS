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

namespace LeetCode.Algorithms.RemoveAllOccurrencesOfSubstring;

/// <inheritdoc />
public sealed class RemoveAllOccurrencesOfSubstringStringBuilder : IRemoveAllOccurrencesOfSubstring
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="part"></param>
    /// <returns></returns>
    public string RemoveOccurrences(string s, string part)
    {
        var stringBuilder = new StringBuilder();

        foreach (var c in s)
        {
            stringBuilder.Append(c);

            if (stringBuilder.Length >= part.Length && stringBuilder.ToString(stringBuilder.Length - part.Length, part.Length) == part)
            {
                stringBuilder.Length -= part.Length;
            }
        }

        return stringBuilder.ToString();
    }
}