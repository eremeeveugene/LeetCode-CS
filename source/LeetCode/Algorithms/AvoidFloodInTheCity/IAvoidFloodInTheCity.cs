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

namespace LeetCode.Algorithms.AvoidFloodInTheCity;

/// <summary>
///     https://leetcode.com/problems/avoid-flood-in-the-city/description/
/// </summary>
public interface IAvoidFloodInTheCity
{
    /// <summary>
    ///     Returns a drying schedule that prevents any lake from flooding.
    /// </summary>
    /// <param name="rains">The lake receiving rain each day, or zero for a dry day.</param>
    /// <returns>
    ///     A schedule containing -1 on rainy days and the lake to dry on dry days,
    ///     or an empty array if preventing a flood is impossible.
    /// </returns>
    int[] AvoidFlood(int[] rains);
}