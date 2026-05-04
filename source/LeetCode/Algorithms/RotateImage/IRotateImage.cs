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

namespace LeetCode.Algorithms.RotateImage;

/// <summary>
///     https://leetcode.com/problems/rotate-image/description/
/// </summary>
public interface IRotateImage
{
    /// <summary>
    ///     Rotates the specified square matrix 90 degrees clockwise in-place.
    /// </summary>
    /// <param name="matrix">The square integer matrix to rotate.</param>
    void Rotate(int[][] matrix);
}