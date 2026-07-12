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

namespace LeetCode.Algorithms.FindKthSmallestPairDistance;

/// <summary>
///     https://leetcode.com/problems/find-k-th-smallest-pair-distance/
/// </summary>
public interface IFindKthSmallestPairDistance
{
    /// <summary>
    ///     Finds the <paramref name="k" />-th smallest distance among all pairs of elements of <paramref name="nums" />,
    ///     where the distance of a pair is the absolute difference of its elements.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <param name="k">The one-based rank of the pair distance to find.</param>
    /// <returns>The <paramref name="k" />-th smallest pair distance.</returns>
    int SmallestDistancePair(int[] nums, int k);
}