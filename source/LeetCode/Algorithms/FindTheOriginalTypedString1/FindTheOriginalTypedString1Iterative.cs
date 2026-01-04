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

namespace LeetCode.Algorithms.FindTheOriginalTypedString1;

/// <inheritdoc />
public class FindTheOriginalTypedString1Iterative : IFindTheOriginalTypedString1
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public int PossibleStringCount(string word)
    {
        var result = 1;

        var previous = word[0];

        for (var i = 1; i < word.Length; i++)
        {
            if (word[i] == previous)
            {
                result++;
            }
            else
            {
                previous = word[i];
            }
        }

        return result;
    }
}