// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.EqualScoreSubstrings;

/// <inheritdoc />
public class EqualScoreSubstringsPrefixSum : IEqualScoreSubstrings
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool ScoreBalance(string s)
    {
        var left = 0;
        var right = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            right += GetScore(c);
        }

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            var score = GetScore(c);

            left += score;
            right -= score;

            if (left == right)
            {
                return true;
            }
        }

        return false;
    }

    private static int GetScore(char c)
    {
        return c - 'a' + 1;
    }
}