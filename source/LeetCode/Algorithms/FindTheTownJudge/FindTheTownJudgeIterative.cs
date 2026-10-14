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

namespace LeetCode.Algorithms.FindTheTownJudge;

/// <inheritdoc />
public sealed class FindTheTownJudgeIterative : IFindTheTownJudge
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2 + t)
    ///     Space complexity - O(n + t)
    /// </remarks>
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

        for (var i = 0; i < trust.Length; i++)
        {
            var t = trust[i];

            if (!judges.TryAdd(t[1], [t[0]]))
            {
                judges[t[1]].Add(t[0]);
            }
        }

        var candidates = new int[judges.Count];

        judges.Keys.CopyTo(candidates, 0);

        for (var i = 0; i < candidates.Length; i++)
        {
            var candidate = candidates[i];

            if (SumOf(judges[candidate]) != sum - candidate)
            {
                continue;
            }

            if (TrustsSomeoneElse(judges, candidate))
            {
                continue;
            }

            return candidate;
        }

        return -1;
    }

    private static bool TrustsSomeoneElse(Dictionary<int, HashSet<int>> judges, int candidate)
    {
        var supporterSets = new HashSet<int>[judges.Count];

        judges.Values.CopyTo(supporterSets, 0);

        for (var i = 0; i < supporterSets.Length; i++)
        {
            if (!supporterSets[i].Contains(candidate))
            {
                continue;
            }

            return true;
        }

        return false;
    }

    private static int SumOf(HashSet<int> values)
    {
        var items = new int[values.Count];

        values.CopyTo(items);

        var sum = 0;

        for (var i = 0; i < items.Length; i++)
        {
            sum += items[i];
        }

        return sum;
    }
}