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

namespace LeetCode.Algorithms.CheckIfOneStringSwapCanMakeStringsEqual;

/// <inheritdoc />
public sealed class CheckIfOneStringSwapCanMakeStringsEqualIterative : ICheckIfOneStringSwapCanMakeStringsEqual
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public bool AreAlmostEqual(string s1, string s2)
    {
        if (s1.Equals(s2))
        {
            return true;
        }

        var differences = new List<int>();

        for (var i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                differences.Add(i);
            }

            if (differences.Count > 2)
            {
                return false;
            }
        }

        return differences.Count == 2 && s1[differences[0]] == s2[differences[1]] && s1[differences[1]] == s2[differences[0]];
    }
}