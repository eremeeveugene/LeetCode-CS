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

namespace LeetCode.Algorithms.ImageOverlap;

/// <summary>
///     https://leetcode.com/problems/image-overlap/description/
/// </summary>
public interface IImageOverlap
{
    /// <summary>
    ///     Finds the largest number of overlapping ones after translating one image without rotation.
    /// </summary>
    /// <param name="img1">The first square binary image.</param>
    /// <param name="img2">The second square binary image of the same size.</param>
    /// <returns>The maximum number of positions containing a one in both images after translation.</returns>
    int LargestOverlap(int[][] img1, int[][] img2);
}