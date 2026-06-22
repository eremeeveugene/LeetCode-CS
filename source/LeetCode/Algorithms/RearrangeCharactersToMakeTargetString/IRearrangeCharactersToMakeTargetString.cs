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

namespace LeetCode.Algorithms.RearrangeCharactersToMakeTargetString;

/// <summary>
///     https://leetcode.com/problems/rearrange-characters-to-make-target-string/description
/// </summary>
public interface IRearrangeCharactersToMakeTargetString
{
    /// <summary>
    ///     Determines the maximum number of copies of <paramref name="target" /> that can be formed by taking and
    ///     rearranging the characters of <paramref name="s" />, where each character of <paramref name="s" /> can be used in
    ///     at most one copy.
    /// </summary>
    /// <param name="s">The source string supplying the available characters.</param>
    /// <param name="target">The string to be assembled from the characters of <paramref name="s" />.</param>
    /// <returns>The maximum number of copies of <paramref name="target" /> that can be formed.</returns>
    int RearrangeCharacters(string s, string target);
}