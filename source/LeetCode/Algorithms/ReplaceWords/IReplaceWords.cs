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

namespace LeetCode.Algorithms.ReplaceWords;

/// <summary>
///     https://leetcode.com/problems/replace-words/
/// </summary>
public interface IReplaceWords
{
    /// <summary>
    ///     Replaces each word in <paramref name="sentence" /> with the shortest root from <paramref name="dictionary" />
    ///     that forms it, leaving words without a matching root unchanged.
    /// </summary>
    /// <param name="dictionary">The list of root words used for replacement.</param>
    /// <param name="sentence">The sentence whose words are replaced by their shortest matching root.</param>
    /// <returns>The resulting sentence after all applicable words have been replaced by their roots.</returns>
    string ReplaceWords(IList<string> dictionary, string sentence);
}