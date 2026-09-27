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

namespace LeetCode.Algorithms.DesignAddAndSearchWordsDataStructure;

/// <summary>
///     https://leetcode.com/problems/design-add-and-search-words-data-structure/description/
/// </summary>
public interface IDesignAddAndSearchWordsDataStructure
{
    /// <summary>
    ///     Adds a lowercase word to the dictionary.
    /// </summary>
    /// <param name="word">The word to add.</param>
    void AddWord(string word);

    /// <summary>
    ///     Determines whether an added word matches the pattern, with each dot matching any single letter.
    /// </summary>
    /// <param name="word">The search pattern containing lowercase letters and at most two dots.</param>
    /// <returns>True if an entire stored word matches the pattern; otherwise, false.</returns>
    bool Search(string word);
}