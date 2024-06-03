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

namespace LeetCode.Algorithms.AppendCharactersToStringToMakeSubsequence;

/// <summary>
///     https://leetcode.com/problems/append-characters-to-string-to-make-subsequence/
/// </summary>
public class AppendCharactersToStringToMakeSubsequenceTwoPointers : IAppendCharactersToStringToMakeSubsequence
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public int AppendCharacters(string s, string t)
    {
        var sPointer = 0;
        var tPointer = 0;

        while (sPointer < s.Length && tPointer < t.Length)
        {
            if (s[sPointer] == t[tPointer])
            {
                tPointer++;
            }

            sPointer++;
        }

        return t.Length - tPointer;
    }
}