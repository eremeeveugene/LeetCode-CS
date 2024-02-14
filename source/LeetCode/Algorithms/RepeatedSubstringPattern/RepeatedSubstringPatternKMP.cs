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

namespace LeetCode.Algorithms.RepeatedSubstringPattern;

/// <inheritdoc />
public class RepeatedSubstringPatternKMP : IRepeatedSubstringPattern
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool RepeatedSubstringPattern(string s)
    {
        var n = s.Length;
        var lps = new int[n];

        ComputeLPSArray(s, n, lps);

        var len = lps[n - 1];

        return len > 0 && n % (n - len) == 0;
    }

    private static void ComputeLPSArray(string s, int n, IList<int> lps)
    {
        var len = 0;
        lps[0] = 0;

        var i = 1;

        while (i < n)
        {
            if (s[i] == s[len])
            {
                len++;
                lps[i] = len;
                i++;
            }
            else
            {
                if (len != 0)
                {
                    len = lps[len - 1];
                }
                else
                {
                    lps[i] = len;
                    i++;
                }
            }
        }
    }
}