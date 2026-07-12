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

namespace LeetCode.Algorithms.TypeOfTriangle;

/// <summary>
///     https://leetcode.com/problems/type-of-triangle/description/
/// </summary>
public interface ITypeOfTriangle
{
    /// <summary>
    ///     Determines the type of triangle (equilateral, isosceles, scalene, or none) that can be formed from the
    ///     three side lengths in <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array containing the three side lengths of the triangle.</param>
    /// <returns>A string describing the triangle type, or "none" if the sides cannot form a triangle.</returns>
    string TriangleType(int[] nums);
}