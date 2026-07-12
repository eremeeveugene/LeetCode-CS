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

namespace LeetCode.Algorithms.BuddyStrings;

/// <inheritdoc />
public sealed class BuddyStringsCounting : IBuddyStrings
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool BuddyStrings(string s, string goal)
    {
        if (s.Length != goal.Length || s.Length < 2)
        {
            return false;
        }

        if (s == goal)
        {
            var duplicates = new bool[26];

            foreach (var index in s.Select(c => c - 'a'))
            {
                if (duplicates[index])
                {
                    return true;
                }

                duplicates[index] = true;
            }

            return false;
        }

        var firstIndex = -1;
        var secondIndex = -1;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == goal[i])
            {
                continue;
            }

            if (firstIndex == -1)
            {
                firstIndex = i;
            }
            else if (secondIndex == -1)
            {
                secondIndex = i;
            }
            else
            {
                return false;
            }
        }

        if (secondIndex == -1)
        {
            return false;
        }

        return s[firstIndex] == goal[secondIndex] && s[secondIndex] == goal[firstIndex];
    }
}