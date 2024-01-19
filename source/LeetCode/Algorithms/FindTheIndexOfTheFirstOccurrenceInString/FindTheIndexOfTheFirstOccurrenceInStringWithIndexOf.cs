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

namespace LeetCode.Algorithms.FindTheIndexOfTheFirstOccurrenceInString;

/// <summary>
///     https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/
/// </summary>
public static class FindTheIndexOfTheFirstOccurrenceInStringWithIndexOf
{
    /// <summary>
    ///     Time complexity - O(n*m)
    /// </summary>
    /// <param name="haystack"></param>
    /// <param name="needle"></param>
    /// <returns></returns>
    public static int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle, StringComparison.OrdinalIgnoreCase);
    }
}