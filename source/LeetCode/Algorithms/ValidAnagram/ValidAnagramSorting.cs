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

namespace LeetCode.Algorithms.ValidAnagram;

/// <inheritdoc />
public class ValidAnagramSorting : IValidAnagram
{
    /// <summary>
    ///     Time complexity - O(n log n  + m log m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsAnagram(string s, string t)
    {
        return s.Length == t.Length && s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));
    }
}