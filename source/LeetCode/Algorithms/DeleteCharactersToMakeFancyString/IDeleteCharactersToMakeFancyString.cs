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

namespace LeetCode.Algorithms.DeleteCharactersToMakeFancyString;

/// <summary>
///     https://leetcode.com/problems/delete-characters-to-make-fancy-string/description/
/// </summary>
public interface IDeleteCharactersToMakeFancyString
{
    /// <summary>
    ///     Deletes the minimum number of characters from <paramref name="s" /> so that no three consecutive characters
    ///     are equal, producing a fancy string.
    /// </summary>
    /// <param name="s">The string to make fancy.</param>
    /// <returns>The resulting fancy string after the deletions.</returns>
    string MakeFancyString(string s);
}