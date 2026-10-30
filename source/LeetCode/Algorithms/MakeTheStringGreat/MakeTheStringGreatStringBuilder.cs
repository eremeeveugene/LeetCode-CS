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

namespace LeetCode.Algorithms.MakeTheStringGreat;

/// <inheritdoc />
public sealed class MakeTheStringGreatStringBuilder : IMakeTheStringGreat
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string MakeGood(string s)
    {
        var stringBuilder = new StringBuilder();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (stringBuilder.Length > 0 && char.ToLowerInvariant(stringBuilder[^1]) == char.ToLowerInvariant(c) && stringBuilder[^1] != c)
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