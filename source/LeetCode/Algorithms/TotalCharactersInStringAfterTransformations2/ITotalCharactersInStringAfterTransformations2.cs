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

namespace LeetCode.Algorithms.TotalCharactersInStringAfterTransformations2;

/// <summary>
///     https://leetcode.com/problems/total-characters-in-string-after-transformations-ii/description/
/// </summary>
public interface ITotalCharactersInStringAfterTransformations2
{
    /// <summary>
    ///     Computes the length of <paramref name="input" /> after applying, <paramref name="transformationsCount" />
    ///     times, the transformation that replaces each character c with the next nums[c - 'a'] consecutive
    ///     characters in the alphabet, wrapping around from <c>'z'</c> to <c>'a'</c>.
    /// </summary>
    /// <param name="input">The string consisting of lowercase English letters to transform.</param>
    /// <param name="transformationsCount">The number of times to apply the transformation.</param>
    /// <param name="nums">The number of characters each of the 26 letters expands into per transformation.</param>
    /// <returns>The length of the resulting string, modulo 10^9 + 7.</returns>
    int LengthAfterTransformations(string input, int transformationsCount, IList<int> nums);
}