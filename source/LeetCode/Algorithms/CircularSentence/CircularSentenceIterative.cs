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

namespace LeetCode.Algorithms.CircularSentence;

/// <inheritdoc />
public sealed class CircularSentenceIterative : ICircularSentence
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(m)
    /// </summary>
    /// <param name="sentence"></param>
    /// <returns></returns>
    public bool IsCircularSentence(string sentence)
    {
        var words = sentence.Split(' ');

        if (words[0][0] != words[^1][^1])
        {
            return false;
        }

        for (var i = 0; i < words.Length - 1; i++)
        {
            if (words[i][^1] != words[i + 1][0])
            {
                return false;
            }
        }

        return true;
    }
}