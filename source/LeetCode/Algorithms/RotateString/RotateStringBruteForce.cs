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
public class RotateStringBruteForce : IRotateString
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="goal"></param>
    /// <returns></returns>
    public bool RotateString(string s, string goal)
    {
        return s.Length == goal.Length && s.Where((t, i) => CanRotateString(s, goal, i)).Any();
    }

    private static bool CanRotateString(string s, string goal, int i)
    {
        return !goal.Where((t, j) => s[(i + j) % s.Length] != t).Any();
    }
}