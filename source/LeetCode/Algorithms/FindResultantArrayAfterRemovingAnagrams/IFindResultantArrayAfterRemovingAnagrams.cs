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

namespace LeetCode.Algorithms.FindResultantArrayAfterRemovingAnagrams;

/// <summary>
///     https://leetcode.com/problems/find-resultant-array-after-removing-anagrams/description/
/// </summary>
public interface IFindResultantArrayAfterRemovingAnagrams
{
    /// <summary>
    ///     Repeatedly removes any word from <paramref name="words" /> that is an anagram of the word immediately preceding it, until no such words remain.
    /// </summary>
    /// <param name="words">The array of words to process.</param>
    /// <returns>The resultant list of words after all anagram removals.</returns>
    IList<string> RemoveAnagrams(string[] words);
}