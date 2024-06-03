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

namespace LeetCode.Algorithms.CheckIfTheSentenceIsPangram;

/// <inheritdoc />
public class CheckIfTheSentenceIsPangramHashSet : ICheckIfTheSentenceIsPangram
{
    private readonly HashSet<char> _alphabetHashSet =
    [
        'a',
        'b',
        'c',
        'd',
        'e',
        'f',
        'g',
        'h',
        'i',
        'j',
        'k',
        'l',
        'm',
        'n',
        'o',
        'p',
        'q',
        'r',
        's',
        't',
        'u',
        'v',
        'w',
        'x',
        'y',
        'z'
    ];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="sentence"></param>
    /// <returns></returns>
    public bool CheckIfPangram(string sentence)
    {
        if (sentence.Length < 26)
        {
            return false;
        }

        var sentenceHashSet = new HashSet<char>(sentence);

        return _alphabetHashSet.All(sentenceHashSet.Contains);
    }
}