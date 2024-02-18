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

namespace LeetCode.Algorithms.IsSubsequence;

/// <inheritdoc />
public class IsSubsequenceIterative : IIsSubsequence
{
    /// <summary>
    ///     Time complexity - O(n*m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
        {
            return true;
        }

        if (t.Length == 0)
        {
            return false;
        }

        var tIndex = 0;
        var sIndex = 0;

        while (tIndex < t.Length && sIndex < s.Length)
        {
            var isFound = false;

            while (tIndex < t.Length && !isFound)
            {
                if (s[sIndex] == t[tIndex])
                {
                    isFound = true;
                }

                tIndex++;
            }

            if (!isFound)
            {
                return false;
            }

            sIndex++;
        }

        return sIndex == s.Length;
    }
}