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
public class IsSubsequenceTwoPointers : IIsSubsequence
{
    /// <summary>
    ///     Time complexity - O(n + m)
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

        var sIndex = 0;
        var tIndex = 0;

        while (tIndex < t.Length)
        {
            if (t[tIndex] == s[sIndex])
            {
                sIndex++;

                if (sIndex == s.Length)
                {
                    return true;
                }
            }

            tIndex++;
        }

        return false;
    }
}