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

namespace LeetCode.Algorithms.RectangleOverlap;

/// <inheritdoc />
public sealed class RectangleOverlapMath : IRectangleOverlap
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool IsRectangleOverlap(int[] rec1, int[] rec2)
    {
        var rec1X1 = rec1[0];
        var rec1Y1 = rec1[1];
        var rec1X2 = rec1[2];
        var rec1Y2 = rec1[3];

        var rec2X1 = rec2[0];
        var rec2Y1 = rec2[1];
        var rec2X2 = rec2[2];
        var rec2Y2 = rec2[3];

        return rec2X1 < rec1X2 && rec2Y1 < rec1Y2 && rec1X1 < rec2X2 && rec1Y1 < rec2Y2;
    }
}