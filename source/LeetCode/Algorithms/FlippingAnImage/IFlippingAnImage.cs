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

namespace LeetCode.Algorithms.FlippingAnImage;

/// <summary>
///     https://leetcode.com/problems/flipping-an-image/description/
/// </summary>
public interface IFlippingAnImage
{
    /// <summary>
    ///     Flips <paramref name="image" /> horizontally by reversing each row and then inverts it by replacing each 0 with
    ///     1 and each 1 with 0.
    /// </summary>
    /// <param name="image">The binary matrix representing the image.</param>
    /// <returns>The resulting image after flipping horizontally and inverting.</returns>
    int[][] FlipAndInvertImage(int[][] image);
}