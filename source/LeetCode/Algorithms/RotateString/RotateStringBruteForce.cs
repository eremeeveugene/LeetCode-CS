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

namespace LeetCode.Algorithms.RotateString;

/// <inheritdoc />
public sealed class RotateStringBruteForce : IRotateString
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length)
        {
            return false;
        }

        for (var i = 0; i < s.Length; i++)
        {
            if (CanRotateString(s, goal, i))
            {
                return true;
            }
        }

        return false;
    }

    private static bool CanRotateString(string s, string goal, int i)
    {
        for (var j = 0; j < goal.Length; j++)
        {
            if (s[(i + j) % s.Length] != goal[j])
            {
                return false;
            }
        }

        return true;
    }
}