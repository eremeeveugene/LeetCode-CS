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

public class FindTheTownJudgeIterative : IFindTheTownJudge
{
    /// <summary>
    ///     Time complexity - O(n^2 + t)
    ///     Space complexity - O(n + t)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="trust"></param>
    /// <returns></returns>
    public int FindJudge(int n, int[][] trust)
    {
        if (trust.Length == 0)
        {
            if (n > 1)
            {
                return -1;
            }

            return 1;
        }

        var sum = n * (n + 1) / 2;

        var judges = new Dictionary<int, HashSet<int>>();

        foreach (var t in trust)
        {
            if (!judges.TryAdd(t[1], [t[0]]))
            {
                judges[t[1]].Add(t[0]);
            }
        }

        foreach (var judge in judges.Where(j =>
                     j.Value.Sum() == sum - j.Key && !judges.Any(v => v.Value.Contains(j.Key))))
        {
            return judge.Key;
        }

        return -1;
    }
}