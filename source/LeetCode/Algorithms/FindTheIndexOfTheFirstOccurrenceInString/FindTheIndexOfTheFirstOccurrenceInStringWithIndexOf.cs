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

/// <inheritdoc />
public class FindTheIndexOfTheFirstOccurrenceInStringWithIndexOf : IFindTheIndexOfTheFirstOccurrenceInString
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="haystack"></param>
    /// <param name="needle"></param>
    /// <returns></returns>
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle, StringComparison.OrdinalIgnoreCase);
    }
}