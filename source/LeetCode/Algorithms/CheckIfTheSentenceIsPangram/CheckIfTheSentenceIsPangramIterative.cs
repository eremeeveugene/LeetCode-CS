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
public sealed class CheckIfTheSentenceIsPangramIterative : ICheckIfTheSentenceIsPangram
{
    private const int AlphabetLength = 26;
    private const int AllLettersSeenMask = (1 << AlphabetLength) - 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CheckIfPangram(string sentence)
    {
        if (sentence.Length < AlphabetLength)
        {
            return false;
        }

        var seen = 0;

        for (var i = 0; i < sentence.Length; i++)
        {
            var index = sentence[i] - 'a';

            seen |= 1 << index;

            if (seen == AllLettersSeenMask)
            {
                return true;
            }
        }

        return false;
    }
}