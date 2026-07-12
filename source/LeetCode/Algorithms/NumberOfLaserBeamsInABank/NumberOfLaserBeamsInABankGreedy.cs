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

namespace LeetCode.Algorithms.NumberOfLaserBeamsInABank;

/// <inheritdoc />
public sealed class NumberOfLaserBeamsInABankGreedy : INumberOfLaserBeamsInABank
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumberOfBeams(string[] bank)
    {
        var m = bank.Length;

        if (m == 1)
        {
            return 0;
        }

        var n = bank[0].Length;

        var numberOfBeams = 0;

        var previousCount = 0;

        for (var i = 0; i < m; i++)
        {
            var currentCount = 0;

            for (var j = 0; j < n; j++)
            {
                if (bank[i][j] == '1')
                {
                    currentCount++;
                }
            }

            if (currentCount <= 0)
            {
                continue;
            }

            numberOfBeams += previousCount * currentCount;

            previousCount = currentCount;
        }

        return numberOfBeams;
    }
}