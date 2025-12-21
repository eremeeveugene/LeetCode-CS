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

namespace LeetCode.Algorithms.DeleteColumnsToMakeSorted2;

/// <inheritdoc />
public sealed class DeleteColumnsToMakeSorted2Greedy : IDeleteColumnsToMakeSorted2
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public int MinDeletionSize(string[] strs)
    {
        var result = 0;

        var n = strs.Length;
        var m = strs[0].Length;

        Span<bool> ignored = stackalloc bool[n - 1];

        for (var i = 0; i < m; i++)
        {
            var needDelete = false;

            for (var j = 0; j < n - 1; j++)
            {
                if (ignored[j])
                {
                    continue;
                }

                if (strs[j][i] <= strs[j + 1][i])
                {
                    continue;
                }

                needDelete = true;

                break;
            }

            if (needDelete)
            {
                result++;

                continue;
            }

            for (var j = 0; j < n - 1; j++)
            {
                if (ignored[j])
                {
                    continue;
                }

                if (strs[j][i] < strs[j + 1][i])
                {
                    ignored[j] = true;
                }
            }
        }

        return result;
    }
}