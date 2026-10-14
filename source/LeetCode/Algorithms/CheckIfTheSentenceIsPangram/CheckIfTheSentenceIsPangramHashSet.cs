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

namespace LeetCode.Algorithms.CheckIfTheSentenceIsPangram;

/// <inheritdoc />
public sealed class CheckIfTheSentenceIsPangramHashSet : ICheckIfTheSentenceIsPangram
{
    private readonly char[] _alphabet =
    [
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
    ];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool CheckIfPangram(string sentence)
    {
        if (sentence.Length < 26)
        {
            return false;
        }

        var sentenceHashSet = new HashSet<char>(sentence);

        for (var i = 0; i < _alphabet.Length; i++)
        {
            var letter = _alphabet[i];

            if (!sentenceHashSet.Contains(letter))
            {
                return false;
            }
        }

        return true;
    }
}