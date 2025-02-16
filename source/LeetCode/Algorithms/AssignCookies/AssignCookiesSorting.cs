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

namespace LeetCode.Algorithms.AssignCookies;

/// <inheritdoc />
public class AssignCookiesSorting : IAssignCookies
{
    /// <summary>
    ///     Time complexity - O(n log n + m log m)
    ///     Space complexity - O(log n + log m)
    /// </summary>
    /// <param name="g"></param>
    /// <param name="s"></param>
    /// <returns></returns>
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        var gIndex = 0;
        var sIndex = 0;

        while (gIndex < g.Length && sIndex < s.Length)
        {
            if (g[gIndex] <= s[sIndex])
            {
                gIndex++;
            }

            sIndex++;
        }

        return gIndex;
    }
}