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

namespace LeetCode.Algorithms.DeleteColumnsToMakeSorted;

/// <inheritdoc />
public sealed class DeleteColumnsToMakeSortedSimulation : IDeleteColumnsToMakeSorted
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public int MinDeletionSize(string[] strs)
    {
        var result = 0;

        var n = strs.Length;
        var m = strs[0].Length;

        for (var j = 0; j < m; j++)
        {
            for (var i = 0; i < n - 1; i++)
            {
                if (strs[i][j] > strs[i + 1][j])
                {
                    result++;

                    break;
                }
            }
        }

        return result;
    }
}