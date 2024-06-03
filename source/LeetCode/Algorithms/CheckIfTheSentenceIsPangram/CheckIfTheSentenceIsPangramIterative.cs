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
public class CheckIfTheSentenceIsPangramIterative : ICheckIfTheSentenceIsPangram
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="sentence"></param>
    /// <returns></returns>
    public bool CheckIfPangram(string sentence)
    {
        if (sentence.Length < 26)
        {
            return false;
        }

        var seen = 0;

        foreach (var index in sentence.Select(c => c - 'a'))
        {
            if (index is >= 0 and < 26)
            {
                seen |= 1 << index;
            }

            if (seen == 0x3FFFFFF)
            {
                return true;
            }
        }

        return false;
    }
}