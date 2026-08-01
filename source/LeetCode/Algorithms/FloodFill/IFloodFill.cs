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

namespace LeetCode.Algorithms.FloodFill;

/// <summary>
///     https://leetcode.com/problems/flood-fill/description/
/// </summary>
public interface IFloodFill
{
    /// <summary>
    ///     Performs a flood fill on <paramref name="image" /> starting at pixel (<paramref name="sr" />, <paramref name="sc" />), replacing the connected
    ///     region of pixels with the starting pixel's original color with <paramref name="color" />.
    /// </summary>
    /// <param name="image">The image represented as a grid of pixel color values.</param>
    /// <param name="sr">The starting pixel's row.</param>
    /// <param name="sc">The starting pixel's column.</param>
    /// <param name="color">The new color to apply to the filled region.</param>
    /// <returns>The image after performing the flood fill.</returns>
    int[][] FloodFill(int[][] image, int sr, int sc, int color);
}