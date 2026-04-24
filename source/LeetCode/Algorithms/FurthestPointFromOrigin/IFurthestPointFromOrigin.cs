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

namespace LeetCode.Algorithms.FurthestPointFromOrigin;

/// <summary>
///     https://leetcode.com/problems/furthest-point-from-origin/description/
/// </summary>
public interface IFurthestPointFromOrigin
{
    /// <summary>
    ///     Calculates the furthest possible distance from the origin after performing all moves.
    /// </summary>
    /// <param name="moves">A string of length n containing only 'L', 'R', and '_' characters.</param>
    /// <returns>The maximum absolute distance from the origin achievable after all moves.</returns>
    int FurthestDistanceFromOrigin(string moves);
}