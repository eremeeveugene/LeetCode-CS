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

namespace LeetCode.Algorithms.FindUniqueBinaryString;

/// <summary>
///     https://leetcode.com/problems/find-unique-binary-string/description/
/// </summary>
public interface IFindUniqueBinaryString
{
    /// <summary>
    ///     Finds a binary string of the same length as the strings in <paramref name="nums" /> that does not appear in
    ///     <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of unique binary strings of equal length.</param>
    /// <returns>A binary string of the same length that is not present in <paramref name="nums" />.</returns>
    string FindDifferentBinaryString(string[] nums);
}