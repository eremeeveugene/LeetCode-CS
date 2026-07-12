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

namespace LeetCode.Algorithms.DistributeCandiesAmongChildren2;

/// <inheritdoc />
public sealed class DistributeCandiesAmongChildren2Math : IDistributeCandiesAmongChildren2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public long DistributeCandies(int n, int limit)
    {
        return GetCombinationsCount(n + 2) - (GetCombinationsCount(n - limit + 1) * 3) + (GetCombinationsCount(n - (2 * (limit + 1)) + 2) * 3) -
               GetCombinationsCount(n - (3 * (limit + 1)) + 2);
    }

    private static long GetCombinationsCount(int n)
    {
        if (n < 0)
        {
            return 0;
        }

        return (long)n * (n - 1) / 2;
    }
}