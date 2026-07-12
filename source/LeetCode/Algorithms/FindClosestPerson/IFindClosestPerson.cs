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

namespace LeetCode.Algorithms.FindClosestPerson;

/// <summary>
///     https://leetcode.com/problems/find-closest-person/description/
/// </summary>
public interface IFindClosestPerson
{
    /// <summary>
    ///     Determines which of the two people at positions <paramref name="x" /> and <paramref name="y" /> is closer to
    ///     the person at position <paramref name="z" />.
    /// </summary>
    /// <param name="x">The position of the first person.</param>
    /// <param name="y">The position of the second person.</param>
    /// <param name="z">The position of the person both are measured against.</param>
    /// <returns>1 if the first person is closer, 2 if the second person is closer, or 0 if they are equidistant.</returns>
    int FindClosest(int x, int y, int z);
}