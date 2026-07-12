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

namespace LeetCode.Algorithms.AssignCookies;

/// <summary>
///     https://leetcode.com/problems/assign-cookies/description/
/// </summary>
public interface IAssignCookies
{
    /// <summary>
    ///     Assigns cookies in <paramref name="s" /> to children with greed factors in <paramref name="g" />, maximizing
    ///     the number of content children.
    /// </summary>
    /// <param name="g">The greed factor of each child.</param>
    /// <param name="s">The size of each available cookie.</param>
    /// <returns>The maximum number of children that can be made content.</returns>
    int FindContentChildren(int[] g, int[] s);
}