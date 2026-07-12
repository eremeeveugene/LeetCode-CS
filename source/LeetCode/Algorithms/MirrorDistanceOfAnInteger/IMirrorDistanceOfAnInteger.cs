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

namespace LeetCode.Algorithms.MirrorDistanceOfAnInteger;

/// <summary>
///     https://leetcode.com/problems/mirror-distance-of-an-integer/description/
/// </summary>
public interface IMirrorDistanceOfAnInteger
{
    /// <summary>
    ///     Computes the absolute difference between <paramref name="n" /> and its mirror image, the number formed by
    ///     reversing the digits of <paramref name="n" />.
    /// </summary>
    /// <param name="n">The non-negative integer to compute the mirror distance for.</param>
    /// <returns>The absolute difference between <paramref name="n" /> and its digit-reversed mirror value.</returns>
    int MirrorDistance(int n);
}