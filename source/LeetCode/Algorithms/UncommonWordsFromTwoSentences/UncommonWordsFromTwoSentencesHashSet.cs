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

namespace LeetCode.Algorithms.UncommonWordsFromTwoSentences;

/// <inheritdoc />
public sealed class UncommonWordsFromTwoSentencesHashSet : IUncommonWordsFromTwoSentences
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </remarks>
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var once = new HashSet<string>();
        var moreThanOnce = new HashSet<string>();

        var s1Words = s1.Split(' ');

        for (var i = 0; i < s1Words.Length; i++)
        {
            var word = s1Words[i];

            if (!once.Add(word))
            {
                moreThanOnce.Add(word);
            }
        }

        var s2Words = s2.Split(' ');

        for (var i = 0; i < s2Words.Length; i++)
        {
            var word = s2Words[i];

            if (!once.Add(word))
            {
                moreThanOnce.Add(word);
            }
        }

        return once.Except(moreThanOnce).ToArray();
    }
}