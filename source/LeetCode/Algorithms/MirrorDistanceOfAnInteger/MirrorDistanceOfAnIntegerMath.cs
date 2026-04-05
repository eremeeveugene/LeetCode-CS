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

namespace LeetCode.Algorithms.MirrorDistanceOfAnInteger;

/// <inheritdoc />
public sealed class MirrorDistanceOfAnIntegerMath : IMirrorDistanceOfAnInteger
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int MirrorDistance(int n)
    {
        var reversed = 0;

        var temp = n;

        while (temp > 0)
        {
            reversed = (reversed * 10) + (temp % 10);

            temp /= 10;
        }

        return Math.Abs(n - reversed);
    }
}