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

namespace LeetCode.Algorithms.FindMinimumLogTransportationCost;

/// <inheritdoc />
public sealed class FindMinimumLogTransportationCostMath : IFindMinimumLogTransportationCost
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public long MinCuttingCost(int n, int m, int k)
    {
        long cutN = Math.Max(0, n - k);
        long cutM = Math.Max(0, m - k);

        return (cutN + cutM) * k;
    }
}