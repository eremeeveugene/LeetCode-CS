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

namespace LeetCode.Algorithms.ValidTriangleNumber;

/// <summary>
///     https://leetcode.com/problems/valid-triangle-number/description/
/// </summary>
public interface IValidTriangleNumber
{
    /// <summary>
    ///     Counts the number of triplets in <paramref name="nums" /> that can form the sides of a valid triangle.
    /// </summary>
    /// <param name="nums">The array of non-negative integers representing candidate side lengths.</param>
    /// <returns>The number of triplets that satisfy the triangle inequality.</returns>
    int TriangleNumber(int[] nums);
}