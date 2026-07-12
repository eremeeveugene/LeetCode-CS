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

namespace LeetCode.Algorithms.LargestPerimeterTriangle;

/// <summary>
///     https://leetcode.com/problems/largest-perimeter-triangle/description/
/// </summary>
public interface ILargestPerimeterTriangle
{
    /// <summary>
    ///     Finds the largest perimeter of a triangle with a non-zero area whose side lengths are taken from
    ///     <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of side lengths.</param>
    /// <returns>The largest possible perimeter of such a triangle, or 0 if no triangle can be formed.</returns>
    int LargestPerimeter(int[] nums);
}