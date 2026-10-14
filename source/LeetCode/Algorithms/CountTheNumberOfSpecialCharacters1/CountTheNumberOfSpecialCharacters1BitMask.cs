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

namespace LeetCode.Algorithms.CountTheNumberOfSpecialCharacters1;

/// <inheritdoc />
public sealed class CountTheNumberOfSpecialCharacters1BitMask : ICountTheNumberOfSpecialCharacters1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumberOfSpecialChars(string word)
    {
        var lower = 0;
        var upper = 0;

        for (var i = 0; i < word.Length; i++)
        {
            var c = word[i];

            if (char.IsLower(c))
            {
                lower |= 1 << (c - 'a');
            }
            else
            {
                upper |= 1 << (c - 'A');
            }
        }

        return int.PopCount(lower & upper);
    }
}