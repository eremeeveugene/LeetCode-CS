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

namespace LeetCode.Algorithms.RepeatedSubstringPattern;

/// <inheritdoc />
public sealed class RepeatedSubstringPatternIterative : IRepeatedSubstringPattern
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool RepeatedSubstringPattern(string s)
    {
        for (var i = 1; i < s.Length; i++)
        {
            if (s.Length % i != 0)
            {
                continue;
            }

            var isRepeated = true;

            for (var j = i; j < s.Length; j++)
            {
                if (s[j] == s[j - i])
                {
                    continue;
                }

                isRepeated = false;

                break;
            }

            if (isRepeated)
            {
                return true;
            }
        }

        return false;
    }
}