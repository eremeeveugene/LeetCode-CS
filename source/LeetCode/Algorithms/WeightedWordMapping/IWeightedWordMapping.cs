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

namespace LeetCode.Algorithms.WeightedWordMapping;

/// <summary>
///     https://leetcode.com/problems/weighted-word-mapping/description/
/// </summary>
public interface IWeightedWordMapping
{
    /// <summary>
    ///     Maps each word in <paramref name="words" /> to a single character: the word's weight is the sum of its
    ///     characters' weights from <paramref name="weights" />, taken modulo <c>26</c> and mapped to a letter in
    ///     reverse alphabetical order (<c>0 -&gt; 'z'</c>, <c>1 -&gt; 'y'</c>, ..., <c>25 -&gt; 'a'</c>).
    /// </summary>
    /// <param name="words">The words to map, each consisting of lowercase English letters.</param>
    /// <param name="weights">An array of length <c>26</c> where <c>weights[i]</c> is the weight of the <c>i</c>th letter.</param>
    /// <returns>A string formed by concatenating the mapped character of each word, in order.</returns>
    string MapWordWeights(string[] words, int[] weights);
}