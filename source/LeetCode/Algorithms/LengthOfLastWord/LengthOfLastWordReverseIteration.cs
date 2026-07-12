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

namespace LeetCode.Algorithms.LengthOfLastWord;

/// <inheritdoc />
public sealed class LengthOfLastWordReverseIteration : ILengthOfLastWord
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int LengthOfLastWord(string s)
    {
        var length = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                length++;
            }
            else if (length > 0)
            {
                break;
            }
        }

        return length;
    }
}