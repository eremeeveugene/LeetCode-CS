// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class UniqueMorseCodeWordsHashSet : IUniqueMorseCodeWords
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

    /// <summary>
    ///     Time complexity - O(n * m)
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public int UniqueMorseRepresentations(string[] words)
    {
        var morseRepresentationsHashSet = new HashSet<string>();

        foreach (var word in words)
        {
            var morseCodeWordStringBuilder = new StringBuilder();

            foreach (var morseCode in word.Select(@char => _morseCodeDictionary[@char]))
            {
                morseCodeWordStringBuilder.Append(morseCode);
            }

            morseRepresentationsHashSet.Add(morseCodeWordStringBuilder.ToString());
        }

        return morseRepresentationsHashSet.Count;
    }
}