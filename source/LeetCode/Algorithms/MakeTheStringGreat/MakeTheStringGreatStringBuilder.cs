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

namespace LeetCode.Algorithms.MakeTheStringGreat;

/// <inheritdoc />
public class MakeTheStringGreatStringBuilder : IMakeTheStringGreat
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string MakeGood(string s)
    {
        var stringBuilder = new StringBuilder();

        foreach (var c in s)
        {
            if (stringBuilder.Length > 0 && char.ToLower(stringBuilder[^1]) == char.ToLower(c) &&
                stringBuilder[^1] != c)
            {
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
            }
            else
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString();
    }
}