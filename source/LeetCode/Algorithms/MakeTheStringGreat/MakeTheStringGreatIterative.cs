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

namespace LeetCode.Algorithms.MakeTheStringGreat;

/// <inheritdoc />
public sealed class MakeTheStringGreatIterative : IMakeTheStringGreat
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </remarks>
    public string MakeGood(string s)
    {
        if (s.Length < 2)
        {
            return s;
        }

        var sList = new List<char>(s.Length);

        for (var j = 0; j < s.Length; j++)
        {
            sList.Add(s[j]);
        }


        var i = 0;

        while (i < sList.Count - 1)
        {
            if (char.ToLower(sList[i]) == char.ToLower(sList[i + 1]) &&
                ((char.IsLower(sList[i]) && char.IsUpper(sList[i + 1])) || (char.IsUpper(sList[i]) && char.IsLower(sList[i + 1]))))
            {
                sList.RemoveAt(i + 1);
                sList.RemoveAt(i);

                i = 0;
            }
            else
            {
                i++;
            }
        }

        return string.Concat(sList);
    }
}