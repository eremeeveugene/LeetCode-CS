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

namespace LeetCode.Algorithms.SentenceSimilarity3;

/// <summary>
///     https://leetcode.com/problems/sentence-similarity-iii/description/
/// </summary>
public interface ISentenceSimilarity3
{
    /// <summary>
    ///     Determines whether <paramref name="sentence1" /> and <paramref name="sentence2" /> can be made
    ///     identical by inserting a contiguous block of words into exactly one of them.
    /// </summary>
    /// <param name="sentence1">The first sentence.</param>
    /// <param name="sentence2">The second sentence.</param>
    /// <returns><see langword="true" /> if the sentences are similar; otherwise, <see langword="false" />.</returns>
    bool AreSentencesSimilar(string sentence1, string sentence2);
}