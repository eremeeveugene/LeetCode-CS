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

namespace LeetCode.Algorithms.FindTheTownJudge;

/// <inheritdoc />
public class FindTheTownJudgeDictionary : IFindTheTownJudge
{
    /// <summary>
    ///     Time complexity - O(n + t)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="trust"></param>
    /// <returns></returns>
    public int FindJudge(int n, int[][] trust)
    {
        var trustCounts = new int[n + 1];
        var trustsSomeone = new bool[n + 1];

        foreach (var t in trust)
        {
            trustCounts[t[0]]--;
            trustCounts[t[1]]++;
            trustsSomeone[t[0]] = true;
        }

        for (var i = 1; i <= n; i++)
        {
            if (trustCounts[i] == n - 1 && !trustsSomeone[i])
            {
                return i;
            }
        }

        return -1;
    }
}