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

namespace LeetCode.Algorithms.LongestUnequalAdjacentGroupsSubsequence1;

/// <inheritdoc />
public sealed class LongestUnequalAdjacentGroupsSubsequence1Greedy : ILongestUnequalAdjacentGroupsSubsequence1
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="words"></param>
    /// <param name="groups"></param>
    /// <returns></returns>
    public IList<string> GetLongestSubsequence(string[] words, int[] groups)
    {
        var result = new List<string> { words[0] };

        var previousGroup = groups[0];

        for (var i = 1; i < groups.Length; i++)
        {
            if (groups[i] == previousGroup)
            {
                continue;
            }

            result.Add(words[i]);

            previousGroup = groups[i];
        }

        return result;
    }
}