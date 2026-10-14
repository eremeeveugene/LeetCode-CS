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

namespace LeetCode.Algorithms.ValidAnagram;

/// <inheritdoc />
public sealed class ValidAnagramSorting : IValidAnagram
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n  + m log m)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var sChars = s.ToCharArray();
        var tChars = t.ToCharArray();

        Array.Sort(sChars);
        Array.Sort(tChars);

        for (var i = 0; i < sChars.Length; i++)
        {
            if (sChars[i] != tChars[i])
            {
                return false;
            }
        }

        return true;
    }
}