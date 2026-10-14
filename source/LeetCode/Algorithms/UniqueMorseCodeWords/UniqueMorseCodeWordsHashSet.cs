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

using System.Text;

namespace LeetCode.Algorithms.UniqueMorseCodeWords;

/// <inheritdoc />
public sealed class UniqueMorseCodeWordsHashSet : IUniqueMorseCodeWords
{
    private readonly Dictionary<char, string> _morseCodeDictionary = new()
    {
        { 'a', ".-" },
        { 'b', "-..." },
        { 'c', "-.-." },
        { 'd', "-.." },
        { 'e', "." },
        { 'f', "..-." },
        { 'g', "--." },
        { 'h', "...." },
        { 'i', ".." },
        { 'j', ".---" },
        { 'k', "-.-" },
        { 'l', ".-.." },
        { 'm', "--" },
        { 'n', "-." },
        { 'o', "---" },
        { 'p', ".--." },
        { 'q', "--.-" },
        { 'r', ".-." },
        { 's', "..." },
        { 't', "-" },
        { 'u', "..-" },
        { 'v', "...-" },
        { 'w', ".--" },
        { 'x', "-..-" },
        { 'y', "-.--" },
        { 'z', "--.." }
    };

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </remarks>
    public int UniqueMorseRepresentations(string[] words)
    {
        var morseRepresentationsHashSet = new HashSet<string>();

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];

            var morseCodeWordStringBuilder = new StringBuilder();

            for (var j = 0; j < word.Length; j++)
            {
                var letter = word[j];

                morseCodeWordStringBuilder.Append(_morseCodeDictionary[letter]);
            }

            morseRepresentationsHashSet.Add(morseCodeWordStringBuilder.ToString());
        }

        return morseRepresentationsHashSet.Count;
    }
}